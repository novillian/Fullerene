using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullerene
{
    //Converts Windows Performance Monitor metrics into Carbon formatted metrics. 
    class Metric
    {
        private long unixTime
        {
            get
            {
                DateTimeOffset dto = new DateTimeOffset(TimeTriggered);
                return dto.ToUnixTimeMilliseconds();
            }
        }
        public DateTime TimeTriggered { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public string toCarbonMetric()
        {
            return String.Format("{0} {1} {2}", Name, Value, unixTime);
        }
    }
}
