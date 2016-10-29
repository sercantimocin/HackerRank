using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarrysArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = Convert.ToInt32(Console.ReadLine());


            while (tryCount-- > 0)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());

                string[] temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(temp, Int32.Parse);

                int inv = 0;

                for (int i = 0; i < arraySize; i++)
                {
                    for (int j = i + 1; j < arraySize; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            inv++;
                        }
                    }
                }

                if (inv % 2 == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO"); ;
            };
        }
    }
}
