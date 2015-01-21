using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_640_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            ChristmasTreeDecorationDiv2 cl = new ChristmasTreeDecorationDiv2();
            // int[] col = new int[]{1,2,3,3};
            // int[] x   = new int[]{1,2,3};
            // int[] y   = new int[]{2,3,4};
            // Console.WriteLine(cl.solve(col, x, y));

            // int[] col = new int[]{1,3,5};
            // int[] x   = new int[]{1,3};
            // int[] y   = new int[]{2,2};
            // Console.WriteLine(cl.solve(col, x, y));

            // int[] col = new int[]{1,1,3,3};
            // int[] x   = new int[]{1,3,2};
            // int[] y   = new int[]{2,1,4};
            // Console.WriteLine(cl.solve(col, x, y));

            // int[] col = new int[]{5,5,5,5};
            // int[] x   = new int[]{1,2,3};
            // int[] y   = new int[]{2,3,4};
            // Console.WriteLine(cl.solve(col, x, y));

            int[] col = new int[]{9,1,1};
            int[] x   = new int[]{3,2};
            int[] y   = new int[]{2,1};
            Console.WriteLine(cl.solve(col, x, y));

            Console.ReadLine();
        }
    }
}
