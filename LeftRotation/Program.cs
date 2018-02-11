using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRotation
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[] { 1, 2, 3, 4, 5 };

            var a = leftRotation(aa, 4);

            foreach (var x in a)
            {
                Console.Write(x + " ");
            }

            Console.ReadKey();
        }

        static int[] leftRotation(int[] a, int d)
        {
            int index = 0;
            int[] resultArray = new int[a.Length];

            for (int i = d; i < a.Length; i++)
            {
                resultArray[index] = a[i];
                index++;
            }

            for (int i = 0; i < d; i++)
            {
                resultArray[index] = a[i];
                index++;
            }

            return resultArray;
        }
    }
}
