using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_630_easy
{
    class DoubleLetter
    {
        public String ableToSolve(String s)
        {
            Boolean flag = false;
            while(!flag) {
                flag = true;
                for (int i = 0; i < s.Length; i++ )
                {
                    if(s[i].Equals(s[i + 1])) {
                        s = s.Remove(i, 2);
                        flag = false;
                    }
                }
            }
            return s.Length == 0 ? "Possible" : "Impossible";
        }
    }
}
