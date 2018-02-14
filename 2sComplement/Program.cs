using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sComplement
{
    class Program
    {
        private static readonly int MAX_VALUE_OF_32_BIT = (int)Math.Pow(2, 33);

        static void Main(string[] args)
        {

            int val = -2;

            int complimented = Get2Compliment(val);

            List<int> list = new List<int>();
            ConvertBinaryPresantation(complimented, list);

            Console.WriteLine(list.Count(x => x == 1));
            Console.ReadKey();
        }

        static int Get2Compliment(int value)
        {
            if (value > 0)
            {
                return MAX_VALUE_OF_32_BIT - value;
            }
            else
            {
                return MAX_VALUE_OF_32_BIT - Math.Abs(value);
            }
        }

        static void ConvertBinaryPresantation(int value, List<int> result)
        {
            if (value < 2)
            {
                result.Add(value);
            }
            else
            {
                int remainder;
                int quotient = Math.DivRem(value, 2, out remainder);
                result.Add(remainder);

                ConvertBinaryPresantation(quotient, result);
            }
        }
    }
}
