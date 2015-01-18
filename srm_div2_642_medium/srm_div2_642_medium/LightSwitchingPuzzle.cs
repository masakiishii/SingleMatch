using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_642_medium
{
    public class LightSwitchingPuzzle
    {
        public int minFlips(String state)
        {
            bool[] boolstate = new bool[state.Length];
            int ans = 0;
            for (int i = 0; i < state.Length; i++)
            {
                boolstate[i] = state[i].Equals('Y') ? true : false;
            }
            for (int i = 0; i < boolstate.Length; i++)
            {
                if (boolstate[i])
                {
                    ans++;
                    for (int j = i; j < boolstate.Length; j += (i + 1))
                    {
                        boolstate[j] = boolstate[j] ? false : true;
                    }
                }
            }
            return ans;
        }
    }
}