using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAbsoluteDifferenceInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            var newa = a.OrderBy(x => x).ToArray();

            int minAbsoluteDiff = int.MaxValue;

            for (int i = 0; i < newa.Length - 1; i++)
            {
                minAbsoluteDiff = Math.Min(minAbsoluteDiff, Math.Abs(newa[i] - newa[i + 1]));
            }

            Console.WriteLine(minAbsoluteDiff);
            Console.ReadKey();
        }
    }
}
