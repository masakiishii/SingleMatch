using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_643_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            TheKingsFactorization fact = new TheKingsFactorization();
            //long n = 12;
            //long[] primes1 = new long[]{2, 3};
            //long[] ans = fact.getVector(n, primes1);


            //long n = 7;
            //long[] primes2 = new long[]{7};
            //long[] ans = fact.getVector(n, primes2);


            //long n = 1764;
            //long[] primes3 = new long[]{2, 3, 7};
            //long[] ans = fact.getVector(n, primes3);


            //long n = 49;
            //long[] primes4 = new long[]{7};
            //long[] ans = fact.getVector(n, primes4);

            //long n = 210;
            //long[] primes5 = new long[]{2, 5};
            //long[] ans = fact.getVector(n, primes5);

            long n = 100000;
            long[] primes6 = new long[]{2, 2, 2, 5, 5};
            long[] ans = fact.getVector(n, primes6);

            for (int i = 0; i < ans.Length; i++ )
            {
                Console.Write(ans[i] + ", ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
