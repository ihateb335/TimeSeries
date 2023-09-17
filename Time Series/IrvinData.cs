using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Series
{
    public enum IrvinAlpha
    {
        Alpha0_05,
        Alpha0_01
    }
    public static class IrvinData
    {
        /// <summary>
        /// Ilim when alpha = 0.05
        /// </summary>
        private static readonly Dictionary<int, double> Data_Alpha0_05 = new Dictionary<int, double>()
        {
            {2, 2.8},
            {3, 2.2 },
            {10, 1.5 },
            {20, 1.3 },
            {30, 1.2 },
            {50, 1.1 },
            {100, 1.0 },
            {400, 0.9 },
        };

        /// <summary>
        /// Ilim when alpha = 0.01
        /// </summary>
        private static readonly Dictionary<int, double> Data_Alpha0_01 = new Dictionary<int, double>()
        {
            {2, 3.7},
            {3, 2.9 },
            {10, 2.0 },
            {20, 1.8 },
            {30, 1.7 },
            {50, 1.6 },
            {100, 1.5 },
            {400, 1.3 },
        };

        /// <summary>
        /// Interpolate N
        /// </summary>
        /// <param name="n">N to interpolate</param>
        /// <param name="data">Irvin data to interpolate</param>
        /// <returns></returns>
        private static double LinearInterpolation(int n, Dictionary<int, double> data)
        {
            if (data.ContainsKey(n)) return data[n];

            var First = data.First();
            var Last = data.Last();

            if (First.Key > n) return First.Value;
            if (First.Key < n) return Last.Value;

            First = data.First((pair) => pair.Key < n);
            Last = data.First((pair) => pair.Key > n);

            return (Last.Value - First.Value) * (n - First.Key) / (Last.Key - First.Key) + First.Value; 
        }

        /// <summary>
        /// Get Ilim
        /// </summary>
        /// <param name="n">n for which Ilim will be calculated</param>
        /// <param name="alpha">alpha for which Ilim will be calculated</param>
        /// <returns></returns>
        public static double Ilim(int n, IrvinAlpha alpha)
        {
            switch (alpha)
            {
                case IrvinAlpha.Alpha0_05:
                    return LinearInterpolation(n, Data_Alpha0_05);
                case IrvinAlpha.Alpha0_01:
                    return LinearInterpolation(n, Data_Alpha0_01);
                default:
                    return 0;
            }
        }

    }
}
