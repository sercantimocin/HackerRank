using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumSubarray
{
    static class Program
    {
        static void Main(string[] args)
        {
            long size = Convert.ToInt64(Console.ReadLine());
            List<long[]> list = new List<long[]>();
            long[,] finalContiguousArray = new long[size, 2];

            long copySize = size;

            do
            {
                long subArraySize = Convert.ToInt64(Console.ReadLine());
                long[] temp = Console.ReadLine().Split(' ').SubArray(0, subArraySize).Select(x => Convert.ToInt64(x)).ToArray();
                list.Add(temp);
                size--;
            }
            while (size > 0);


            foreach (var intArray in list)
            {
                long start = 0;
                long len = 0;
                long max = MaxSumSubarray(intArray,out start,out len);
                var contiguousArrayItem = intArray.SubArray(start, len);

                for (long i = 0; i < copySize-1; i++)
                {
                    finalContiguousArray[i, 0] = max;
                    Console.Write(finalContiguousArray[i, 0]);


                    for (long j = 1; j < 2; j++)
                    {

                        if (contiguousArrayItem.Length > 1)
                        {
                            finalContiguousArray[i, j] = contiguousArrayItem.Where(x => x > 0).Sum();
                            Console.Write(" ");
                            Console.Write(finalContiguousArray[i, j]);
                        }
                        else
                        {
                            finalContiguousArray[i, 0] = max;
                            Console.Write(" ");
                            Console.Write(finalContiguousArray[i, 0]);
                        }
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }

        static long MaxSumSubarray(long[] a, out long start, out long len)
        {

            start = 0;
            len = 1;
            long sum = a[0];

            long curStart = 0;
            long curLen = 1;
            long curSum = a[0];

            for (long i = 1; i < a.Length; i++)
            {

                if (a[i] >= curSum + a[i])
                {
                    curStart = i;
                    curLen = 1;
                    curSum = a[i];
                }
                else
                {
                    curLen++;
                    curSum += a[i];
                }

                if ((curSum > sum) ||
                    (curSum == sum && curLen < len) ||
                    (curSum == sum && curLen == len && curStart < start))
                {
                    start = curStart;
                    len = curLen;
                    sum = curSum;
                }

            }

            return sum;

        }

        public static T[] SubArray<T>(this T[] data, long index, long length)
        {
            T[] result = new T[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        static int[] FindMaximumSubarray(int[] array)
        {
            int[] resultArray = null;

            if (array.Any(x => x < 0))
            {
                long maxSum = array.Sum();
                long startIndex = 0;
                long lenght = 1;

                do
                {
                    var tempArray = array.SubArray(startIndex, lenght);

                    if (tempArray.Sum() > maxSum)
                    {
                        maxSum = tempArray.Sum();
                        resultArray = tempArray;
                    }

                    if (startIndex + lenght == array.Length)
                    {
                        startIndex++;
                        lenght = 1;
                    }
                    else
                    {
                        lenght++;
                    }

                }
                while (startIndex < array.Length);
            }
            else
            {
                resultArray = array;
            }


            return resultArray;
        }
    }
}
