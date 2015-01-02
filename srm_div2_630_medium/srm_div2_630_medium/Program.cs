using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Egalitarianism3Easy egalitarianism = new Egalitarianism3Easy();
            int n = 4;
            int[] a = { 1, 1, 1};
            int[] b = { 2, 3, 4};
            int[] len = { 1, 1, 1};
            Console.WriteLine(egalitarianism.maxCities(n, a, b, len));
            Console.ReadLine();
        }
    }
}
