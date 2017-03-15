using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToTutorialChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(temp, Int32.Parse);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == v)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
