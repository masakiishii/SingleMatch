using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_635_easy
{
    class IdentifyingWood
    {
        public String check(String s, String t)
        {
            int index = 0;
            int tlength = t.Length;
            for (int i = 0; i < s.Length; i++ )
            {
                if(s[i] == t[index]) {
                    index++;
                }
                if(tlength == index) {
                    return "Yes, it's wood.";
                }
            }
            return "Nope.";
        }
    }
}