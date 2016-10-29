using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viral_Advertising
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = Convert.ToInt32(Console.ReadLine());

            int[] likes = new int[day+1];

            likes[0] = 0;
            likes[1] = 2;

            for (int i = 2; i <= day; i++)
            {
                likes[i] = (likes[i-1] * 3) / 2;
            }

            Console.WriteLine(likes.Sum());
            Console.ReadKey();
        }
    }
}
