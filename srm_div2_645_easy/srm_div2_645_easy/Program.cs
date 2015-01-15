using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_645_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] colony = new int[] {5, 3, 4, 6, 1 };
            //int[] colony = new int[] {1, 5, 4, 9};
            //int[] colony = new int[] {78, 34, 3, 54, 44, 99};
            int[] colony = new int[] {32, 68, 50, 89, 34, 56, 47, 30, 82, 7, 21, 16, 82, 24, 91};
            BacteriesColony bc = new BacteriesColony();
            int[] ans = bc.performTheExperiment(colony);
            for (int i = 0; i < ans.Length; i++ )
            {
                Console.Write(ans[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
