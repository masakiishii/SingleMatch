using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_640_easy
{
    public class ChristmasTreeDecorationDiv2
    {
        public int solve(int[] col, int[] x, int[] y) {
            int ans = 0;
            for (int i = 0; i < x.Length; i++ )
            {
                if(col[x[i] - 1 ] != col[y[i] - 1]) {
                    ans++;
                }
            }
            return ans;
        }
    }
}
