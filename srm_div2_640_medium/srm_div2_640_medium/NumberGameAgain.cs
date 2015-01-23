using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_640_medium
{
    class NumberGameAgain
    {
        public long solve(int k, long[] table)
        {
            long goal = (1L << k) - 1;
            int n = table.Length;
            bool[] flaglist = new bool[n];
            HashSet<long> hash = new HashSet<long>();
            Array.Sort(table);
            for (int i = 0; i < n; i++ )
            {
                long current = table[i];
                int p = 0;
                while(current > 1) {
                    if(hash.Contains(current)) {
                        flaglist[i] = true;
                        break;
                    }
                    current >>= 1;
                    p++;
                }
                hash.Add(table[i]);
                if(!flaglist[i]) {
                    goal -= (1L << (k - p)) - 1;
                }
            }
            return goal - 1;
        }
    }
}
