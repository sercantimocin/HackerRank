using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingAnagrams
{
    using System.Data;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(AnagramIndepementCalculate("cde", "abc"));

            Console.ReadKey();
        }

        static int AnagramIndepementCalculate(string s1, string s2)
        {
            Dictionary<char, int> s1freq = new Dictionary<char, int>();
            Dictionary<char, int> s2freq = new Dictionary<char, int>();

            for (char i = 'a'; i <= 'z'; i++)
            {
                s1freq.Add(i, 0);
                s2freq.Add(i, 0);
            }

            char[] s1Chars = s1.ToCharArray();

            foreach (char i in s1Chars)
            {
                s1freq[i]++;
            }

            char[] s2Chars = s2.ToCharArray();
            foreach (char i in s2Chars)
            {
                s2freq[i]++;
            }

            int mustNeedDeleteCount = 0;

            for (char i = 'a'; i <= 'z'; i++)
            {
                mustNeedDeleteCount += Math.Abs(s1freq[i] - s2freq[i]);
            }

            return mustNeedDeleteCount;
        }
    }
}
