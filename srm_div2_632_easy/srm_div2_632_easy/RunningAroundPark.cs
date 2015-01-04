using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_632_easy
{
    class RunningAroundPark
    {
        public int numberOfLap(int N, int[] d) {
            int number = 1;
            for (int i = 0; i < d.Length; i++ )
            {
                if((i != d.Length -1) && (d[i] >= d[i+1])) {
                    number++;
                }
            }
            return number;
        }
    }
}
