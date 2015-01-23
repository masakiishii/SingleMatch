using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_639_medium
{
    public class AliceGameEasy
    {
        public long findMinimumValue(long x, long y)
        {
            long sum = x + y;
            long count = 1;
            long ans = 0;
            while(sum > 0) {
                sum -= count++;
            }
            if(sum < 0) {
                return -1;
            }
            count -= 1;
            while(count > 0) {
                if(count <= x) {
                    x -= count;
                    ans++;
                }
                count--;
            }
            return x == 0 ? ans : -1;
        }
    }
}
