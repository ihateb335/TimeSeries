using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace TimeSeriesLibrary
{
    [Serializable]
    public class TimeSeries
    {
        public TimeSeries(string filepath)
        {
            TimePoints = Load(filepath).ToList();
            Setup();
            Initialize();
        }

        public TimeSeries(IEnumerable<TimePoint> timePoints)
        {
            TimePoints = timePoints.ToList();
            Setup();
            Initialize();
        }

        private void Setup()
        {
            Expected = TimePoints.Sum(point => point.Y) / N;
            Dispersion = TimePoints.Sum(point => (point.Y - Expected) * (point.Y - Expected)) / (N - 1);
        }

        protected virtual void Initialize()
        {

        }


        /// <summary>
        /// Рівні часового ряду
        /// </summary>
        public List<TimePoint> TimePoints { get; internal set; }

       

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

  

        #region Зберігання та завантаження
        /// <summary>
        /// Зберегти дані часового ряду
        /// </summary>
        /// <param name="filepath">Шлях до зберігання</param>
        /// <param name="value">Дані для зберігання</param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void Save(string filepath, object value)
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
        /// <summary>
        /// Зберегти дані часового ряду
        /// </summary>
        /// <param name="filepath"></param>
        public void Save(string filepath) => Save(filepath, this);

        /// <summary>
        /// Завантажити дані з файлу
        /// </summary>
        /// <param name="filepath">Шлях до даних</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException">Файл не було знайдено</exception>
        /// <exception cref="InvalidOperationException">Помилка при десеріалізації</exception>
        private static IEnumerable<TimePoint> Load(string filepath)
        {
            if (!File.Exists(filepath))
                throw new FileNotFoundException($"File {filepath} not found");
            try
            {
                // Read the JSON content from the file
                string jsonContent = File.ReadAllText(filepath);

                // Deserialize the JSON content into the timePoints list
                return JsonConvert
                    .DeserializeObject<List<TimePoint>>(jsonContent)
                    .Select((obj, i) => { obj.T = i; return obj; })
                    ;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Error deserializing JSON from {filepath}: {ex.Message}");
            }
        }
        #endregion

    }
}
