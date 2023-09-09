using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Time_Series
{
    [Serializable]
    public class TimeSeries
    {
        public List<TimePoint> timePoints { get; private set; }
        public List<TimePoint> CorrelationCoefs { get; private set; }
        [JsonIgnore]
        public int N => timePoints.Count;
        public double Expected { get; private set; } = double.NaN;
        public double Dispersion { get; private set; } = double.NaN;


        private void CalculateDispersion()
        {
            Expected = timePoints.Sum(point => point.Y) / N;
            Dispersion = timePoints.Sum(point => (point.Y - Expected) * (point.Y - Expected) ) / (N - 1);
        }

        public double CalculateCorrelationCoefficient(int L)
        {
            if (L > N) throw new ArgumentException("L is out of bounds");

            double nl = N - L, yyLSum = 0, ySum = 0, yLSum = 0, y2Sum = 0, yL2Sum = 0, y = 0, yL = 0;

            for (int i = 0; i < N - L; i++)
            {
                y = timePoints[i].Y;
                yL = timePoints[i + L].Y;

                yyLSum += y * yL;
                ySum += y;
                yLSum += yL;
                y2Sum += y * y;
                yL2Sum += yL * yL;
            }

            return (nl * yyLSum - ySum * yLSum) / Math.Sqrt(nl * y2Sum - ySum * ySum) / Math.Sqrt(nl * yL2Sum - yLSum * yLSum);
        }
        public void CalculateCorrelationCoefficients(int min, int max)
        {
            CorrelationCoefs = new List<TimePoint>();
            for (int i = min; i <= max; i++)
            {
                CorrelationCoefs.Add(new TimePoint { T = i, Y = CalculateCorrelationCoefficient(i) });
            }
        }

        // Load method for JSON deserialization
        public static TimeSeries Load(string filepath)
        {
            if(!File.Exists(filepath)) 
                throw new FileNotFoundException($"File {filepath} not found");
            try
            {
                // Read the JSON content from the file
                string jsonContent = File.ReadAllText(filepath);

                // Deserialize the JSON content into the timePoints list
                var timePoints = JsonConvert.DeserializeObject<List<TimePoint>>(jsonContent);

                var result = new TimeSeries { timePoints = timePoints };

                result.CalculateDispersion();

                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error deserializing JSON from {filepath}: {ex.Message}");
            }
        }
        public void SaveTimePoints(string filepath) => Save(filepath, timePoints);
        public void SaveAllData(string filepath) => Save(filepath, this);
        // Save method for JSON serialization
        private void Save(string filepath, object value)
        {
            try
            {
                // Serialize the timePoints list to JSON
                string jsonContent = JsonConvert.SerializeObject(value);

                // Write the JSON content to the file
                File.WriteAllText(filepath, jsonContent);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error serializing to JSON and saving to {filepath}: {ex.Message}");
            }
        }

    }
}
