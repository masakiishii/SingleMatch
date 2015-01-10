using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_643_easy
{
    class TheKingsArmyDiv2
    {
        public int getNumber(String[] state)
        {
            Boolean flag1 = false;
            Boolean flag2 = false;
            for (int i = 0; i < state.Length; i++ )
            {
                for (int j = 0; j < state[0].Length; j++ )
                {
                    if(state[i][j] == 'H') {
                        flag1 = true;
                        if (j + 1 < state[0].Length && state[i][j].Equals(state[i][j + 1]))
                        {
                            flag2 = true;
                        }
                        if (i + 1 < state.Length && state[i][j].Equals(state[i + 1][j]))
                        {
                            flag2 = true;
                        }
                    }
                }
            }
            if(flag1 && flag2) {
                return 0;
            }
            if(flag1) {
                return 1;
            }
            return 2;
        }
    }
}
