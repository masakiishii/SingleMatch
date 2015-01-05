using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_632_medium
{
    class Program
    {
        static void Main(string[] args)
        {
            PotentialGeometricSequence potential = new PotentialGeometricSequence();
            int[] d = new int[] { 0, 1 ,2};
            //int[] d = new int[] { 1, 2 ,4};
            //int[] d = new int[] { 3, 2 , 1, 0};
            //int[] d = new int[] { 1, 2, 4, 8, 16};
            //int[] d = new int[] { 1, 3, 5, 5, 5, 5, 64, 4, 23, 2, 3, 4, 5, 4, 3};
            Console.WriteLine(potential.numberOfSubsequence(d));
            Console.ReadLine();
        }
    }
}
