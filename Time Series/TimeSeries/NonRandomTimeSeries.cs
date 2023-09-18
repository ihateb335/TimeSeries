using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics.Distributions;

namespace TimeSeriesLibrary
{
    public class NonRandomTimeSeries : TimeSeries
    {

        public NonRandomTimeSeries(string filepath, int N1, double alpha = 0.05) : base(filepath) {
            Setup(N1, alpha);
        }

        public NonRandomTimeSeries(IEnumerable<TimePoint> timePoints, int N1, double alpha = 0.05) : base(timePoints) {
           Setup(N1, alpha);
        }

        private void Setup(int N1, double alpha)
        {
            if (N1 >= N || N1 <= 0) throw new ArgumentException($"Значення N1 має бути більше за 0 і менше за {N}");

            this.N1 = N1;
            this.N2 = N - N1;

            var seq1 = new TimeSeries(TimePoints.Take(N1));
            var seq2 = new TimeSeries(TimePoints.Skip(N1));

            YI = seq1.Expected;
            YII = seq2.Expected;

            SI = seq1.Dispersion;
            SII = seq2.Dispersion;

            StudentCriterium = (YI - YII) / Math.Sqrt((N1 - 1) * SI + (N2 - 1) * SII) * Math.Sqrt(N1 * N2 * (N1 + N2 - 2) / (N1 + N2));

            StudentQuantile = -StudentT.InvCDF(0.0, 1.0, N1 + N2 - 2, alpha / 2.0);

            FisherCriterium = Math.Max(SI, SII) / Math.Min(SI, SII);

            F1 = FisherSnedecor.InvCDF(N1 - 1.0, N2 - 1.0, alpha / 2.0);
            F2 = FisherSnedecor.InvCDF(N1 - 1.0, N2 - 1.0, 1.0 - alpha / 2.0);

            if (N % 2 == 1) YMed = TimePoints[N / 2].Y;
            else YMed = (TimePoints[(N - 1) / 2].Y + TimePoints[(N - 1) / 2 + 1].Y) / 2;

            var series = TimePoints.Select(p =>
            {
                if (p.Y > YMed) return 1;
                else if (p.Y < YMed) return -1;
                else return 0;
            });
            FindTheLongestSeries(series);
        }

        public void FindTheLongestSeries(IEnumerable<int> series)
        {
            int prev = 0;
            T = 0;
            V = 0;
            int currentLength = 1;
            foreach (var current in series)
            {
                if (current != 0)
                {
                    if (prev != current)
                    {
                        T = Math.Max(T, currentLength);
                        currentLength = 1;
                        ++V;
                    }

                    if (prev == current)
                    {
                        ++currentLength;
                    }
                }
                prev = current;
            }
            if (prev != 0 || V > 0)
            {
                T = Math.Max(T, currentLength);
            }
        }

        #region Criterium I
        /// <summary>
        /// Кількість елементів у першій виборочній підмножині
        /// </summary>
        public int N1 { get; private set; }
        /// <summary>
        /// Кількість елементів у другій виборочній підмножині
        /// </summary>
        public int N2 { get; private set; }

        /// <summary>
        /// Виборочне середнє I
        /// </summary>
        public double YI { get; private set; }
        /// <summary>
        /// Виборочне середнє II
        /// </summary>
        public double YII { get; private set; }

        /// <summary>
        /// Виборочна дисперсія I
        /// </summary>
        public double SI { get; private set; }
        /// <summary>
        /// Виборочна дисперсія II
        /// </summary>
        public double SII { get; private set; }

        /// <summary>
        /// Критерій Стьюдента
        /// </summary>
        public double StudentCriterium { get; private set; }

        /// <summary>
        /// Квантиль розподілу Стьюдсона
        /// </summary>
        public double StudentQuantile { get; private set; }

        /// <summary>
        /// Критерій Фішера
        /// </summary>
        public double FisherCriterium { get; private set; }

        /// <summary>
        /// Критерій Фішера 1
        /// </summary>
        public double F1 { get; private set; }
        /// <summary>
        /// Критерій Фішера 2
        /// </summary>
        public double F2 { get; private set; }
        #endregion

        #region Criterium II

        /// <summary>
        /// Медіана ряду
        /// </summary>
        public double YMed { get; private set; }

        /// <summary>
        /// Загальна кількість серій
        /// </summary>
        public int V { get; private set; }
        /// <summary>
        /// Довжина найбільшої серії
        /// </summary>
        public int T { get; private set; }


        #endregion
        public string Result =>
            ( Math.Abs(StudentCriterium) > StudentQuantile || (F1 < FisherCriterium && FisherCriterium < F2) ) || //Перший критерій
            V > (int)((N + 2 - 1.96 * Math.Sqrt(N - 1)) / 2) && T < (int)(1.43 * Math.Log(N + 1)) // Другий критерій
            ?
            "Відсутність невипадкової компоненти ряда" :
            "Присутня невипадкова компонента ряду";

    }
}
