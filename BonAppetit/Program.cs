using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonAppetit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(a_temp, Int32.Parse);
            int billPerOne = Convert.ToInt32(Console.ReadLine());

            int perCost = (array.Sum() - array[k]) / 2;

            if (billPerOne==perCost)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(billPerOne-perCost);
            }
        }
    }
}
