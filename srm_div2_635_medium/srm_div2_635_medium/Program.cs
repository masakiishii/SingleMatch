using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_635_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticLaw ql = new QuadraticLaw();
            Console.WriteLine(ql.getTime(1));
            Console.WriteLine(ql.getTime(2));
            Console.WriteLine(ql.getTime(5));
            Console.WriteLine(ql.getTime(6));
            Console.WriteLine(ql.getTime(7));
            Console.WriteLine(ql.getTime(1482));
            Console.WriteLine(ql.getTime(1000000000000000000));
            Console.WriteLine(ql.getTime(31958809614643170));
            Console.ReadLine();
        }
    }
}
