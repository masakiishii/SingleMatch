using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_643_medium
{
    class TheKingsFactorization
    {
        public long[] getVector(long N, long[] primes)
        {
            List<long> anslist = new List<long>();
            for (int i = 0; i < primes.Length; i++ )
            {
                N /= primes[i];
                anslist.Add(primes[i]);
            }
            for (int i = 0; i < primes.Length - 1; i++ )
            {
                for (long x = primes[i]; x <= primes[i + 1]; x++)
                {
                    if (N % x == 0)
                    {
                        N /= x;
                        anslist.Add(x);
                        break;
                    }
                }
            }
            if(N > 1) {
                anslist.Add(N);
            }
            anslist.Sort();
            return anslist.ToArray();
        }
    }
}
