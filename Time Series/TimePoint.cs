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
        public double T { get; set; }
        public double Y { get; set; }
    }
}
