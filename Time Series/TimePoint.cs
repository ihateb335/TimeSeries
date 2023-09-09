using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Series
{
    [Serializable]
    public class TimePoint
    {
        /// <summary>
        /// Рівень часового ряду
        /// </summary>
        public double T { get; set; }

        /// <summary>
        /// Значення рівню часового ряду
        /// </summary>
        public double Y { get; set; }
    }
}
