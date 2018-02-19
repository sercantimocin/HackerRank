using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximizingXor
{
    class Program
    {
        static void Main(string[] args)
        {

            int l = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int result = maximizingXor(l, r);
            Console.WriteLine(result);

            Console.ReadKey();
        }

        static int maximizingXor(int l, int r)
        {
            int result = int.MinValue;

            for (int i = l; i <= r; i++)
            {
                for (int j = i + 1; j <= r; j++)
                {
                    int temp = i ^ j;

                    if (temp > result)
                    {
                        result = temp;
                    }
                }
            }

            return result;
        }
    }
}
