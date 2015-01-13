using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_642_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            ForgotfulAddition fa = new ForgotfulAddition();
            Console.WriteLine(fa.minNumber("22"));
            Console.WriteLine(fa.minNumber("123"));
            Console.WriteLine(fa.minNumber("1289"));
            Console.WriteLine(fa.minNumber("31415926"));
            Console.WriteLine(fa.minNumber("98765"));
            Console.ReadLine();
        }
    }
}
