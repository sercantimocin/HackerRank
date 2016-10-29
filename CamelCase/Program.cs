using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = Console.ReadLine();

            var charArray = text.ToCharArray();

            Console.WriteLine(charArray.Count(c=>c>=65 && c<=90));

            Console.ReadKey();
        }
    }
}
