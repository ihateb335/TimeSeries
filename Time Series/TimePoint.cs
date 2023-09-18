using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSeriesLibrary
{
    [Serializable]
    public class TimePoint
    {

        public static TimePoint Empty => new TimePoint();

        /// <summary>
        /// Рівень часового ряду
        /// </summary>
        public double T { get; set; } = 0;

        /// <summary>
        /// Значення рівню часового ряду
        /// </summary>
        public double Y { get; set; } = 0;

        public override string ToString()
        {
            return $"T: {T}, Y:{Y, 0:F4}";
        }
    }
}
