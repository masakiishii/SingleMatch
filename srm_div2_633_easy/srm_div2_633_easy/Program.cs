using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_633_easy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 13;
            Target target = new Target();
            string[] ans = target.draw(n);
            for (int i = 0; i < n; i++ )
            {
                Console.WriteLine(ans[i]);
            }
            Console.ReadLine();
        }
    }
}
