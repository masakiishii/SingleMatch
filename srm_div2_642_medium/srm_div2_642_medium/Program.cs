using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_642_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            LightSwitchingPuzzle lsp = new LightSwitchingPuzzle();
            String state = "YYYYYY";
            Console.WriteLine(lsp.minFlips(state));
            state = "YNYNYNYNY";
            Console.WriteLine(lsp.minFlips(state));
            state = "NNNNNNNNNN";
            Console.WriteLine(lsp.minFlips(state));
            state = "YYYNYYYNYYYNYYNYYYYN";
            Console.WriteLine(lsp.minFlips(state));
            state = "NYNNYNNNYNNNNYNNNNNYNNNNNNYNNNNNNNY";
            Console.WriteLine(lsp.minFlips(state));
            Console.ReadLine();
        }
    }
}
