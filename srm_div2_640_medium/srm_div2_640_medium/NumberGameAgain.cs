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
            Array.Sort(table);
            int n = table.Length;
            bool[] use = new bool[n];
            HashSet<long> set = new HashSet<long>();
            for (int i = 0; i < n; i++)
            {
                long v = table[i];
                int t = 0;
                while (v > 1)
                {
                    if (set.Contains(v))
                    {
                        use[i] = true;
                        break;
                    }
                    v >>= 1;
                    t++;
                }
                set.Add(table[i]);
                if (!use[i])
                {
                    goal -= (1L << (k - t)) -1;
                }
            }
            return goal - 1;
        }
    }
}
