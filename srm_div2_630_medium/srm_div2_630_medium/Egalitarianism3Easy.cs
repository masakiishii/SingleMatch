using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Egalitarianism3Easy
    {
        int [, ] v = new int[11, 11];
        public int maxCities(int n, int[] a, int[] b, int[] len)
        {
            int ans = 1;
            
            for(int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++ )
                {
                    v[i, j] = (i == j) ? 0 : int.MaxValue;
                }
            }

            for (int i = 0; i < a.Length; i++ )
            {
                a[i]--;
                b[i]--;
                v[a[i], b[i]] = len[i];
                v[b[i], a[i]] = len[i];
            }

            for (int k = 0; k < n; k++ )
            {
                for (int i = 0; i < n; i++ )
                {
                    for (int j = 0; j < n; j++ )
                    {
                        if(k != 1 && i != j && j != k) {
                            v[i, j] = Math.Min(v[i, j], v[i, k] + v[k, j]);
                        }
                    }
                }
            }

            for (int i = 0; i < (1 << n); i++ )
            {
                List<int> tmp = new List<int>();
                for (int j = 0; j < n; j++ )
                {
                    bool flag = (i & (1 << j)) > 0 ? true : false;
                    if(flag) {
                        tmp.Add(j);
                    }
                }
                if(tmp.Count() <= 2) {
                    continue;
                }
                int q = v[tmp[0], tmp[1]];
                bool flag2 = true;
                for (int t = 0; t < tmp.Count() && flag2; t++ )
                {
                    for (int u = t + 1; u < tmp.Count() && flag2; u++ )
                    {
                        if(v[tmp[t], tmp[u]] != q) {
                            flag2 = false;
                        }
                    }
                }
                if(flag2) {
                    ans = Math.Max(ans, tmp.Count());
                }
            }
            return ans;
        }
    }
}
