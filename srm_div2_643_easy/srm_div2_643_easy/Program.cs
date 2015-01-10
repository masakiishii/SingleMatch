using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_643_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            TheKingsArmyDiv2 army = new TheKingsArmyDiv2();
            //String[] grid = new String[] {
            //    "SSSSS",
            //    "SSHHS",
            //    "SSSSS"
            //};
            String[] grid = new String[] {
                "SSSSS",
                "SSHSH",
                "HSSSS"
            };
            Console.WriteLine(army.getNumber(grid));
            Console.ReadLine();
        }
    }
}
