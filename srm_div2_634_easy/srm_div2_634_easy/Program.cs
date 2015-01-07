using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_634_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] d = new int[] { 1, 2, 3, 4, 4, 3, 2, 1};
            MountainRanges check = new MountainRanges();
            Console.WriteLine(check.countPeeks(d));
            Console.ReadLine();
        }
    }
}
