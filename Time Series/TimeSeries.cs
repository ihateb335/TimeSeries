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
        /// <summary>
        /// Рівні часового ряду
        /// </summary>
        public List<TimePoint> TimePoints { get; private set; }
        /// <summary>
        /// Корреляційні коефіцієнти
        /// </summary>
        public List<TimePoint> CorrelationCoefs { get; private set; }

        /// <summary>
        /// Кількість рівнів часового ряду
        /// </summary>
        [JsonIgnore]
        public int N => TimePoints.Count;
        /// <summary>
        /// Оцінка матиматичного очікування часового ряду
        /// </summary>
        public double Expected { get; private set; } = double.NaN;

        /// <summary>
        /// Оцінка дисперсії часового ряду
        /// </summary>
        public double Dispersion { get; private set; } = double.NaN;

        /// <summary>
        /// Підрахунок дисперсії часового ряду
        /// </summary>
        private void CalculateDispersion()
        {
            Expected = TimePoints.Sum(point => point.Y) / N;
            Dispersion = TimePoints.Sum(point => (point.Y - Expected) * (point.Y - Expected) ) / (N - 1);
        }

        /// <summary>
        /// Підрахунок корреляційного коефіцієнту з лагом L
        /// </summary>
        /// <param name="L">Корреляційний лаг</param>
        /// <returns>Коефіцієнт корреляції</returns>
        /// <exception cref="ArgumentException">При перевищенні значення N лагом</exception>
        public double CalculateCorrelationCoefficient(int L)
        {
            if (L > N) throw new ArgumentException("L is out of bounds");

            double nl = N - L, yyLSum = 0, ySum = 0, yLSum = 0, y2Sum = 0, yL2Sum = 0, y = 0, yL = 0;

            for (int i = 0; i < N - L; i++)
            {
                y = TimePoints[i].Y;
                yL = TimePoints[i + L].Y;

                yyLSum += y * yL;
                ySum += y;
                yLSum += yL;
                y2Sum += y * y;
                yL2Sum += yL * yL;
            }

            return (nl * yyLSum - ySum * yLSum) / Math.Sqrt(nl * y2Sum - ySum * ySum) / Math.Sqrt(nl * yL2Sum - yLSum * yLSum);
        }

        /// <summary>
        /// Підрахування корреляційних коефіцієнтів
        /// </summary>
        /// <param name="min">Мінімальний кореляційний коефіцієнт</param>
        /// <param name="max">Максимальний кореляційний коефіцієнт</param>
        public void CalculateCorrelationCoefficients(int min, int max)
        {
            CorrelationCoefs = new List<TimePoint>();
            for (int i = min; i <= max; i++)
            {
                CorrelationCoefs.Add(new TimePoint { T = i, Y = CalculateCorrelationCoefficient(i) });
            }
        }

        /// <summary>
        /// Завантажити дані з файлу
        /// </summary>
        /// <param name="filepath">Шлях до даних</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException">Файл не було знайдено</exception>
        /// <exception cref="InvalidOperationException">Помилка при десеріалізації</exception>
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

                var result = new TimeSeries { TimePoints = timePoints };

                result.CalculateDispersion();

                return result;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error deserializing JSON from {filepath}: {ex.Message}");
            }
        }

        /// <summary>
        /// Зберегти значення рівнів поточного часового ряду
        /// </summary>
        /// <param name="filepath">Шлях до зберігання</param>
        public void SaveTimePoints(string filepath) => Save(filepath, TimePoints);
        /// <summary>
        /// Зберегти всі дані поточного часового ряду
        /// </summary>
        /// <param name="filepath">Шлях до зберігання</param>
        public void SaveAllData(string filepath) => Save(filepath, this);

        /// <summary>
        /// Зберегти дані часового ряду
        /// </summary>
        /// <param name="filepath">Шлях до зберігання</param>
        /// <param name="value">Що зберігати</param>
        /// <exception cref="InvalidOperationException"></exception>
        protected void Save(string filepath, object value)
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
