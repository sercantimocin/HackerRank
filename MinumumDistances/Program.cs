using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinumumDistances
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(a_temp, Int32.Parse);

            int distance = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j] && (j - i) < distance)
                    {
                        distance = j - i;
                    }
                }
            }

            if (distance == int.MaxValue)
            {
                distance = -1;
            }

            Console.WriteLine(distance);
        }
    }
}
