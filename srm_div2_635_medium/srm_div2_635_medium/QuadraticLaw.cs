using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_635_medium
{
    class QuadraticLaw
    {
        public long getTime(long d)
        {
            long t = (long)Math.Sqrt(d);
            while(t * t + t > d) {
                t--;
            }
            return t;
        }
    }
}
