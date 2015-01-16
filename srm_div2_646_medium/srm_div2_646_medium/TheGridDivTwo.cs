using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srm_div2_646_medium
{
    public class TheGridDivTwo
    {
        private int[] dx = new int[] {1, 0, -1, 0 };
        private int[] dy = new int[] {0, 1,  0, -1};
        private int[, ] distance = new int[2000, 2000];
        public int find(int[] x, int[] y, int k)
        {
            if(x.Length == 0) {
                return k;
            }
            int ans = 0;
            for (int i = 0; i < x.Length; i++ )
            {
                x[i] += 1000;
                y[i] += 1000;
                distance[x[i], y[i]] = -1;
            }
            distance[1000, 1000] = -1;
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();
            Tuple<int, int> start = new Tuple<int, int>(1000, 1000);
            queue.Enqueue(start);
            while(queue.Count != 0) {
                Tuple<int, int> tuple = queue.Dequeue();
                for (int i = 0; i < 4; i++ )
                {
                    int posX = tuple.Item1 + dx[i];
                    int posY = tuple.Item2 + dy[i];
                    if(0 <= posX && posX < 1000 + k && 0 <= posY && posY < 1000 + k && distance[posX, posY] == 0) {
                        distance[posX, posY] = distance[tuple.Item1, tuple.Item2] + 1;
                        if(distance[posX, posY] == k) {
                            ans = Math.Max(ans, posX);
                        }
                        if(distance[posX, posY] < k) {
                            Tuple<int, int> pair = new Tuple<int, int>(posX, posY);
                            queue.Enqueue(pair);
                        }
                    }
                }
            }
            return ans == 0 ? 0 : ans - 1001;
        }
    }
}
