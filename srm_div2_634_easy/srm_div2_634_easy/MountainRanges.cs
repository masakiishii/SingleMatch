using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_634_easy
{
    class MountainRanges
    {
        public int countPeeks(int[] heights)
        {
            int counter = 0;
            if(heights.Length == 1) {
                return 1;
            }
            else {
                if(heights[0] > heights[1]) {
                    counter++;
                }
                for (int i = 1; i < heights.Length - 1; i++ )
                {
                    if(heights[i - 1] < heights[i] && heights[i] > heights[i+1]) {
                        counter++;
                    }
                }
                if(heights[heights.Length - 2] < heights[heights.Length - 1]) {
                    counter++;
                }
                return counter;
            }
        }
    }
}
