using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] a =
            {
                new int[]{ 1, 1 ,1 ,0 ,0 ,0},
                new int[]{ 0, 1 ,0 ,0, 0 ,0},
                new int[]{ 1, 1 ,1 ,0 ,0 ,0},
                new int[]{ 0, 0, 2 ,4 ,4 ,0},
                new int[]{ 0, 0 ,0 ,2 ,0 ,0},
                new int[]{ 0, 0 ,1, 2, 4 ,0}
            };

            hourglassSum(a);
            Console.ReadKey();
        }

        //2D Array - DS
        //https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        static int hourglassSum(int[][] arr)
        {
            int bestSum = int.MinValue;

            for (int c = 0; c < 4; c++)
            {
                for (int r = 0; r < 4; r++)
                {
                    int firstRowSum = arr[r][c] + arr[r][c + 1] + arr[r][c + 2];
                    int secondRowSum = arr[r + 1][c + 1];
                    int thirdRowSum = arr[r+2][c] + arr[r + 2][c + 1] + arr[r + 2][c + 2];

                    int hourGlassSum = firstRowSum + secondRowSum + thirdRowSum;

                    if (bestSum < hourGlassSum)
                    {
                        bestSum = hourGlassSum;
                    }
                }
            }

            return bestSum;
        }


        //Arrays: Left Rotation
        //https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        static int[] rotLeft(int[] a, int d)
        {

            int i = d;
            int[] result = new int[a.Length];

            for (int j = 0; j < a.Length; j++)
            {
                i = i % a.Length;
                result[j] = a[i];
                i++;
            }

            return result;
        }
    }
}
