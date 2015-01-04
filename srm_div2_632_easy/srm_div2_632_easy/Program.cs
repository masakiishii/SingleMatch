using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_632_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            RunningAroundPark running = new RunningAroundPark();

            //int N = 3;
            //int[] d = new int[] {1, 2, 3};
            int N = 24;
            int[] d = new int[] {6, 6};
            //int N = 3;
            //int[] d = new int[] {1, 2, 3};
            //int N = 3;
            //int[] d = new int[] {1, 2, 3};
            //int N = 3;
            //int[] d = new int[] {1, 2, 3};
            int ans = running.numberOfLap(N, d);
            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
