using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);

            int difX = x1 - x2;
            int difV = v1 - v2;

            if (difX > 0 && difV < 0 && difX % difV == 0)
            {
                Console.Write("YES");
            }
            else if (difX < 0 && difV > 0 && difX % difV == 0)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}
