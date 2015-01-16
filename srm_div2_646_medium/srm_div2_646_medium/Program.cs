using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_646_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] x = new int[] {1, 1, 1, 1};
            // int[] y = new int[] {-2, -1, 0, 1};
            // int k = 4;
            // int[] x = new int[] {};
            // int[] y = new int[] {};
            // int k = 1000;
             int[] x = new int[] {-1, 0, 0, 1};
             int[] y = new int[] {0, -1, 1, 0};
             int k = 9;
            //int[] x = new int[] {1,0,0,-1,-1,-2,-2,-3,-3,-4,-4};
            //int[] y = new int[] {0,-1,1,-2,2,-3,3,-4,4,-5,5};
            //int k = 47;
            TheGridDivTwo solve = new TheGridDivTwo();
            Console.WriteLine(solve.find(x, y, k));
            Console.ReadLine();
        }
    }
}
