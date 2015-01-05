using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_632_medium
{
    class PotentialGeometricSequence
    {
        public int numberOfSubsequences(int[] d)
        {
            int ans = d.Length;
            int abs;
            for (int i = 0; i < d.Length - 1; i++ )
            {
                abs = d[i + 1] - d[i];
                ans++;
                for (int j = i + 2; j < d.Length; j++ )
                {
                    int k = d[j] - d[j-1];
                    if(k == abs) {
                        ans++;
                    }
                    else if(k != abs) {
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
