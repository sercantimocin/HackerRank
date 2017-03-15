using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = Convert.ToInt32(Console.ReadLine());

            string[] temp = Console.ReadLine().Split(' ');
            int[] array = Array.ConvertAll(temp, Int32.Parse);

            int tempItem = array[array.Length - 1];

            for (int i = array.Length - 1; i > 0; i--)
            {
                int current = array[i];
                int before = array[i - 1];

                if (tempItem < before)
                {
                    array[i] = before;
                }
                else
                {
                    array[i] = tempItem;
                    tempItem = before;
                }

                Console.Write(array[i] + " ");
            }

            Console.Write(array[0]);
            Console.ReadKey();
        }
    }
}
