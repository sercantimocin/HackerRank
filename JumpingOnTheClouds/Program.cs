using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine())-1;
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(c_temp, Int32.Parse);

            int countIteration = 0;
            int currentNode = 0;

            do
            {
                if (n>= (currentNode + 2) && array[currentNode + 2]==0)
                {
                    currentNode = currentNode + 2;
                }
                else
                {
                    currentNode++;
                }

                countIteration++;
            }
            while (currentNode < n);

            Console.WriteLine(countIteration);
            Console.ReadKey();
        }
    }
}
