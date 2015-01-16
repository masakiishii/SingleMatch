using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_646_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 47, 7};
            int k = 2;
            TheConsecutiveIntegersDivTwo cl = new TheConsecutiveIntegersDivTwo();
            Console.WriteLine(cl.find(array, k));
            Console.ReadLine();
        }
    }
}
