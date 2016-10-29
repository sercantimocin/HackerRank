using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(c_temp, Int32.Parse);


            var distArray = array.Distinct();

            int count = distArray.Aggregate(0, (current, item) => current + array.Count(x => x == item) / 2);

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
