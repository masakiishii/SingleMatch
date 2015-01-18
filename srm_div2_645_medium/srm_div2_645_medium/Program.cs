using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_645_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] positions = new int[] { 1, 3, 10, 20};
            // int[] lengths = new int[] { 2, 2, 5, 3};
            // int[] positions = new int[] { 100, 50, 1};
            // int[] lengths = new int[] { 10, 2, 1};
            int[] positions = new int[] { 4, 10, 100, 13, 80};
            int[] lengths = new int[] { 5, 3, 42, 40, 9};
            // int[] positions = new int[] { 5606451, 63581020, 81615191, 190991272, 352848147, 413795385, 468408016, 615921162, 760622952, 791438427};
            // int[] lengths = new int[] {42643329, 9909484, 58137134, 99547272, 39849232, 15146704, 144630245, 604149, 15591965, 107856540};
            ConnectingCars connect = new ConnectingCars();
            Console.WriteLine(connect.minimizeCost(positions, lengths));
            Console.ReadLine();
            "NYNNYNNNYNNNNYNNNNNYNNNNNNYNNNNNNNY"

            "YNYYNYYYNYYYYNYYYYYNYYYYYYNYYYYYYYN"
            "YYYNNNYNNNYNYYYNYNYYYNYNYNNNYNYNYNN"
            "YYYYNNYYNNYYYYYYYNYNYNYYYNNYYNYYYNN"
            "YYYYYNYYNYYYYYNYYNYYYNYYNNNYYYYYYNY"
            "YYYYYYYYNYYNYYNYYYYYYNYNNNNYYNYYYNY"
            "YYYYYYYYYYYNYYNYYNYYYNYNNNYYYNYYYNY"
            "YYYYYYYYYYYYYYNYYNYYYNYYNNYYYNYYYNY"
            "YYYYYYYYYYYYYYYYYNYYYNYYNNYYYYYYYNY"
            "YYYYYYYYYYYYYYYYYYYYYNYYNNYYYYYYYNY"
            "YYYYYYYYYYYYYYYYYYYYYYYYNNYYYYYYYNY"
            "YYYYYYYYYYYYYYYYYYYYYYYYYNYYYYYYYNY"
            "YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYNY"
            "YYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY"
            "NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN"

        }
    }
}
