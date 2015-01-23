using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_640_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            // int k = 3;
            // long[] table = new long[] {2,4,6};
            // NumberGameAgain nga = new NumberGameAgain();
            // Console.WriteLine(nga.solve(k, table));

            // int k = 5;
            // long[] table = new long[] {2,3};
            // NumberGameAgain nga = new NumberGameAgain();
            // Console.WriteLine(nga.solve(k, table));

            // int k = 5;
            // long[] table = new long[] {};
            // NumberGameAgain nga = new NumberGameAgain();
            // Console.WriteLine(nga.solve(k, table));

            int k = 40;
            long[] table = new long[] {2,4,8,16,32141531,2324577,1099511627775,2222222222,33333333333,4444444444,2135};
            NumberGameAgain nga = new NumberGameAgain();
            Console.WriteLine(nga.solve(k, table));

            // int k = 40;
            // long[] table = new long[] {};
            // NumberGameAgain nga = new NumberGameAgain();
            // Console.WriteLine(nga.solve(k, table));

            Console.ReadLine();
        }
    }
}
