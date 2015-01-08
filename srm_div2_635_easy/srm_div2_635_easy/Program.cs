using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_635_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentifyingWood idWood = new IdentifyingWood();
            Console.WriteLine(idWood.check("absdefgh", "asdf"));
            Console.WriteLine(idWood.check("oxoxoxox", "ooxxoo"));
            Console.WriteLine(idWood.check("oxoxoxox", "xxx"));
            Console.WriteLine(idWood.check("qwerty", "qwerty"));
            Console.WriteLine(idWood.check("string", "longstring"));
            Console.ReadLine();
        }
    }
}
