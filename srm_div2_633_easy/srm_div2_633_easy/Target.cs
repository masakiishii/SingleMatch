using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_633_easy
{
    class Target
    {
        public string[] draw(int n)
        {
            char[, ] coodination = new char[n, n];
            string[] ans = new string[n];
            for(int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++ )
                {
                    coodination[i, j] = ' ';
                }
            }
            for(int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++ )
                {
                    if(Math.Max(Math.Abs(i - n / 2), Math.Abs(j - n / 2)) % 2 == 0 ) {
                        coodination[i, j] = '#';
                    }
                }
            }
            for(int i = 0; i < n; i++) {
                StringBuilder builder = new StringBuilder();
                for (int j = 0; j < n; j++ )
                {
                    builder.Append(coodination[i, j]);
                }
                ans[i] = builder.ToString();
            }
            return ans;
        }
    }
}
