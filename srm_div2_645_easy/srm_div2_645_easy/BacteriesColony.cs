using System;
using System.Collections.Generic;
using System.Linq;using System.Text;
using System.Threading.Tasks;

namespace srm_div2_645_easy
{
    class BacteriesColony
    {
        public int[] performTheExperiment(int[] colonies)
        {
            int [] answercolonies = new int[colonies.Length];
            colonies.CopyTo(answercolonies, 0);
            Boolean flag = true;
            while(flag) {
                flag = false;
                for (int i = 1; i < colonies.Length - 1; i++ )
                {
                    if(colonies[i - 1] > colonies[i] && colonies[i] < colonies[i + 1]) {
                        flag = true;
                        answercolonies[i]++;
                    }
                    if(colonies[i - 1] < colonies[i] && colonies[i] > colonies[i + 1]) {
                        flag = true;
                        answercolonies[i]--;
                    }
                }
                answercolonies.CopyTo(colonies, 0);
            }
            return answercolonies
                ;
        }
    }
}
