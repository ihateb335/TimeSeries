using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesLibrary
{
    public class AnomalousTimeSeries : TimeSeries
    {
        public AnomalousTimeSeries(string filepath) : base(filepath)
        {
            double sy = Math.Sqrt(Dispersion);
            IrvinAnomalies = new double[N - 1]
                    .Select(
                        (x, i) => Math.Abs(TimePoints[i + 1].Y - TimePoints[i].Y) / sy
                        )
                    .ToArray();
        }

        /// <summary>
        /// Масив для визначення аномалій
        /// </summary>
        public double[] IrvinAnomalies { get; private set; }
    }
}
