using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSumPairs
{
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(a_temp, Int32.Parse);

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((array[i] + array[j]) % k == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
