using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] texts = new string[n];
            for (int a0 = 0; a0 < n; a0++)
            {
                texts[a0] = Console.ReadLine();

                Console.WriteLine(texts[a0].Distinct().Count());
            }

            //Parallel.ForEach(
            //    texts,
            //    (text) =>
            //        {
            //            CalculateCost(text);
            //        });


            Console.ReadKey();
        }


        private static void CalculateCost(string text)
        {
            StringBuilder sb = new StringBuilder(text.Substring(0, 2));
            int cost = 2;

            int cursor = 2;

            while (text.Length > cursor)
            {
                if (text.Length >= (cursor + 2) && sb.ToString().Contains(text.Substring(cursor, 2)))
                {
                    int maxSubCharSize = 2;
                    for (int j = 3; j < text.Length - cursor - 3; j++)
                    {
                        if (sb.ToString().Contains(text.Substring(cursor, j)))
                        {
                            maxSubCharSize = j;
                        }
                        else
                        {
                            break;
                        }
                    }

                    sb.Append(text.Substring(cursor, maxSubCharSize));
                    cursor = cursor + maxSubCharSize;
                }
                else
                {
                    cost++;
                    cursor++;
                }
            }

            Console.WriteLine(cost);
        }

    }
}
