using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_639_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 7;
            long y = 14;
            AliceGameEasy alice = new AliceGameEasy();
            Console.WriteLine(alice.findMinimumValue(x, y));
            x = 10;
            y = 0;
            Console.WriteLine(alice.findMinimumValue(x, y));
            x = 932599670050;
            y = 67400241741;
            Console.WriteLine(alice.findMinimumValue(x, y));
            x = 7;
            y = 13;
            Console.WriteLine(alice.findMinimumValue(x, y));
            x = 0;
            y = 0;
            Console.WriteLine(alice.findMinimumValue(x, y));
            x = 100000;
            y = 400500;
            Console.WriteLine(alice.findMinimumValue(x, y));
            Console.ReadLine();
        }
    }
}
