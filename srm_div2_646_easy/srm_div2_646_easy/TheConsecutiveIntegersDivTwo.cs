using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace srm_div2_646_easy
{
    public class TheConsecutiveIntegersDivTwo
    {
        public int find(int[] numbers, int k)
        {
            Debugger.Break();
            if(k == 1) {
                return 0;
            }
            int smallestrange = int.MaxValue;
            int tmp;
            for(int i = 0; i < numbers.Length; i++) {
                for(int j = 1; i < numbers.Length; i++) {
                    tmp = Math.Abs(numbers[i] - numbers[j]);
                    if(smallestrange > tmp) {
                        smallestrange = tmp;
                    }
                }
            }
            return smallestrange - 1;
        }
    }
}
