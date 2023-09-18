using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesLibrary
{
    public class CorrelationTimeSeries: TimeSeries
    {
        public CorrelationTimeSeries(string filepath, int min, int max): base(filepath) {
            CorrelationCoefs = new List<TimePoint>();
            for (int i = min; i <= max; i++)
            {
                CorrelationCoefs.Add(new TimePoint { T = i, Y = CalculateCorrelationCoefficient(i) });
            }
        }

        /// <summary>
        /// Корреляційні коефіцієнти
        /// </summary>
        public List<TimePoint> CorrelationCoefs { get; private set; }

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
    }
}
