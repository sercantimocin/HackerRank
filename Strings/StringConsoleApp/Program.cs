using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //makeAnagram("fcrxzwscanmligyxyvym", "jxwtrhvujlmrpdoqbisbwhmgpmeoke");

            int[][] a =
            {
                new int[] {5, 1},
                new int[] {2, 1},
                new int[] {1, 1},
                new int[] {8, 1},
                new int[] {10, 0},
                new int[] {5, 0}
            };

            luckBalance(3, a);

            Console.ReadKey();
        }

        //https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        static int makeAnagram(string a, string b)
        {
            var chars1 = new int[256];
            var chars2 = new int[256];

            for (int i = 0; i < a.Length; i++)
            {
                chars1[a[i]]++;
            }

            for (int i = 0; i < b.Length; i++)
            {
                chars2[b[i]]++;
            }


            int result = a.Length + b.Length;
            int pairs = 0;
            for (int i = 0; i < 256; i++)
            {
                if (chars1[i] > 0 && chars2[i] > 0)
                {
                    pairs += Math.Min(chars1[i], chars2[i]);
                }
            }

            return result - pairs - pairs;

        }

        //https://www.hackerrank.com/challenges/ctci-ransom-note/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        static void checkMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int j = 0; j < magazine.Length; j++)
            {
                if (words.ContainsKey(magazine[j]))
                {
                    words[magazine[j]]++;
                }
                else
                {
                    words.Add(magazine[j], 1);
                }
            }

            for (int i = 0; i < note.Length; i++)
            {
                if (words.ContainsKey(note[i]) && words[note[i]] > 0)
                {
                    words[note[i]]--;
                }
                else
                {
                    Console.Write("No");
                    return;
                }
            }

            Console.Write("Yes");
        }

        //https://www.hackerrank.com/challenges/mark-and-toys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
        static int maximumToys(int[] prices, int k)
        {
            Array.Sort(prices);

            int i = 0;
            int count = 0;
            while (k > 0 && i < prices.Length)
            {
                if (prices[i] > k)
                {
                    break;
                }
                else
                {
                    k -= prices[i];
                    count++;
                }

                i++;
            }

            return count;
        }

        //https://www.hackerrank.com/challenges/luck-balance/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=greedy-algorithms
        static int luckBalance(int k, int[][] contests)
        {

            int minVal = Int32.MaxValue;
            int score = 0;
            int unImportantCount = 0;

            for (int i = 0; i < contests.Length; i++)
            {
                if (contests[i][1] == 0)
                {
                    score = score + contests[i][0];
                    unImportantCount++;
                }
                contests[i][0] = contests[i][0] * contests[i][1];

            }

            for (int i = 0; i < contests.Length - 1; i++)
            {
                for (int j = i + 1; j < contests.Length; j++)
                {
                    if (contests[i][0] < contests[j][0])
                    {
                        int temp = contests[i][0];
                        contests[i][0] = contests[j][0];
                        contests[j][0] = temp;
                    }
                }
            }

            for (int i = 0; i < contests.Length - unImportantCount; i++)
            {
                if (k > 0)
                {
                    score += contests[i][0];
                    k--;
                }
                else
                {
                    score -= contests[i][0];
                }
            }
            return score;
        }

        static void whatFlavors(int[] cost, int money)
        {
            var indexMap = new Dictionary<int, int>();

            for (int i = 0; i < cost.Length - 1; i++)
            {
                for (int j = i + 1; j < cost.Length; j++)
                {
                    if (cost[i] > cost[j])
                    {
                        int temp = cost[i];
                        cost[i] = cost[j];
                        cost[j] = temp;

                        if (indexMap.ContainsKey(i))
                        {
                            indexMap[i] = j;
                        }
                        else
                        {
                            indexMap.Add(i, j);
                        }
                    }
                }
            }

            for (int i = 0; i < cost.Length - 1; i++)
            {
                for (int j = i + 1; j < cost.Length; j++)
                {
                    int tempSum = cost[i] + cost[j];
                    if (money == tempSum)
                    {
                        int x = indexMap.ContainsKey(i) ? indexMap[i] : i;
                        int y = indexMap.ContainsKey(j) ? indexMap[j] : j;

                        Console.Write(x + 1);
                        Console.Write(" ");
                        Console.WriteLine(y + 1);
                        return;
                    }
                }
            }
        }

        //static void whatFlavors(int[] cost, int money)
        //{

        //    var results = new Dictionary<int, int>();
        //    int maxSum = Int32.MinValue;
        //    int maxI = 0, maxJ = 0;

        //    for (int i = 0; i < cost.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < cost.Length; j++)
        //        {

        //            int tempSum = cost[i] + cost[j];

        //            if (money == tempSum)
        //            {
        //                Console.Write(i + 1);
        //                Console.Write(" ");
        //                Console.WriteLine(j + 1);
        //                return;
        //            }
        //            else if (money > tempSum && maxSum < tempSum)
        //            {
        //                maxSum = tempSum;
        //                maxI = i;
        //                maxJ = j;
        //            }
        //        }
        //    }

        //    Console.Write(maxI + 1);
        //    Console.Write(" ");
        //    Console.WriteLine(maxJ + 1);
        //}


        //static void whatFlavors(int[] cost, int money)
        //{

        //    int minCost = cost[0];
        //    int minInd = 0;
        //    for (int i = 1; i < cost.Length; i++)
        //    {
        //        if (minCost > cost[i])
        //        {
        //            minCost = cost[i];
        //            minInd = i;
        //        }
        //    }

        //    while (true)
        //    {
        //        for (int i = 0; i < cost.Length; i++)
        //        {
        //            if (i != minInd)
        //            {
        //                int tempSum = cost[i] + minCost;
        //                if (money == tempSum)
        //                {
        //                    if (minInd < i)
        //                    {
        //                        Console.Write(minInd + 1);
        //                        Console.Write(" ");
        //                        Console.WriteLine(i + 1);
        //                    }
        //                    else
        //                    {
        //                        Console.Write(i + 1);
        //                        Console.Write(" ");
        //                        Console.WriteLine(minInd + 1);
        //                    }

        //                    return;
        //                }
        //            }
        //        }

        //        int minLimitCost = minCost + 1;
        //        minCost = Int32.MaxValue;
        //        for (int i = 0; i < cost.Length; i++)
        //        {
        //            if (minLimitCost <= cost[i] && minCost > cost[i])
        //            {
        //                minCost = cost[i];
        //                minInd = i;
        //            }
        //        }
        //    }
        //}

    }
}
