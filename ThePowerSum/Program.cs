using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePowerSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());

            int solutions = 0;
            Process(0, X, 1, N, ref solutions);
            Console.WriteLine(solutions);
        }

        static void Process(int currentSum, int targetSum, int currentNumber, int n, ref int solutions)
        {
            if (currentSum == targetSum)
            {
                solutions++;
                return; 
            }

            for (int i = currentNumber; currentSum + (int)Math.Pow(i, n) <= targetSum; i++)
                Process(currentSum + (int)Math.Pow(i, n), targetSum, i + 1, n, ref solutions);
        }
    }
}
