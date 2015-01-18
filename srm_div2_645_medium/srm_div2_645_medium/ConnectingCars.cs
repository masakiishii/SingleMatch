using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_645_medium
{
    public class ConnectingCars
    {
        public long minimizeCost(int[] positions, int[] lengths)
        {
            List<Tuple<int, int>> tuplelist = new List<Tuple<int, int>>();
            for (int i = 0; i < positions.Length; i++ )
            {
                tuplelist.Add(new Tuple<int, int>(positions[i], positions[i] + lengths[i]));
            }
            tuplelist.Sort((a, b) => a.Item1.CompareTo(b.Item1));
            foreach(var ele in tuplelist) {
                Console.WriteLine(ele);
            }
            long ans = 0;
            int listlen = tuplelist.Count;
            for (int i = 1; i < listlen; i++)
            {
                long diff = tuplelist[i].Item1 - tuplelist[i - 1].Item2;
                ans += Math.Min(diff * i, diff * (listlen - i));
            }
            return ans;
        }
    }
}
