using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumAbsoluteDifferenceInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] a_temp = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            //var newa = a.OrderBy(x => x).ToArray();

            //int minAbsoluteDiff = int.MaxValue;

            //for (int i = 0; i < newa.Length - 1; i++)
            //{
            //    minAbsoluteDiff = Math.Min(minAbsoluteDiff, Math.Abs(newa[i] - newa[i + 1]));
            //}

            //Console.WriteLine(minAbsoluteDiff);
            //Console.ReadKey();

            int[][] array = new int[6][];

            string[] a_temp = Console.ReadLine().Split(' ');
            array[0] = Array.ConvertAll(a_temp, Int32.Parse);
            a_temp = Console.ReadLine().Split(' ');
            array[1] = Array.ConvertAll(a_temp, Int32.Parse);
            a_temp = Console.ReadLine().Split(' ');
            array[2] = Array.ConvertAll(a_temp, Int32.Parse);
            a_temp = Console.ReadLine().Split(' ');
            array[3] = Array.ConvertAll(a_temp, Int32.Parse);
            a_temp = Console.ReadLine().Split(' ');
            array[4] = Array.ConvertAll(a_temp, Int32.Parse);
            a_temp = Console.ReadLine().Split(' ');
            array[5] = Array.ConvertAll(a_temp, Int32.Parse);

            int square = 0;
            int rectangle = 0;
            int polygon = 0;

            for (int i = 0; i < 6; i++)
            {
                if (array[i][0] == array[i][1] && array[i][2] == array[i][3])
                {
                    square++;
                }
                else if ((array[i][0] == array[i][2]) && (array[i][1] == array[i][3]))
                {
                    rectangle++;
                }
                else
                {
                    polygon++;
                }
            }

            Console.WriteLine("{0} {1}",1,2);
        }
    }
}
