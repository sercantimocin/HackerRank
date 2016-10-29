using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheCloudsRevisited
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(c_temp, Int32.Parse);

            int energy = 100;

            for (int i = k; i <= n; i += k)
            {
                if (array[i % n] == 1)
                {
                    energy -= 2;
                }

                energy--;
            }

            Console.WriteLine(energy);
        }
    }
}
