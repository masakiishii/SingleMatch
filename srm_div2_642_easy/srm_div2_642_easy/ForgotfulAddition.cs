using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_642_easy
{
    class ForgotfulAddition
    {
        public int minNumber(String expression)
        {
            int ans  = int.MaxValue;
            int pre  = 0;
            int post = 0;
            int sum  = 0; 
            for (int i = 1; i < expression.Length; i++ )
            {
                pre  = int.Parse(expression.Substring(0, i));
                post = int.Parse(expression.Substring(i));
                sum = pre + post;
                if(ans > sum) {
                    ans = sum;
                }
            }
            return ans;
        }
    }
}
