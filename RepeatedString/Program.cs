using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());

            var array = text.ToCharArray();

            long division = n / text.Length;
            int rem = (int)(n - (division * text.Length));

            long val1 = text.Substring(0, rem).ToCharArray().Count(x => x == 'a');
            long val2 = array.Count(x => x == 'a') * division;

            Console.WriteLine(val2 + val1);
        }
    }
}
