using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2sComplement
{
    class Program
    {
        private static readonly long MAX_VALUE_OF_32_BIT = (long)Math.Pow(2, 32);

        static void Main(string[] args)
        {

            int val = -2;

            long complimented = Get2Compliment(val);

            List<int> list = new List<int>();
            ConvertBinaryPresantation(complimented, list);

            Console.WriteLine(list.Count(x => x == 1));
            Console.ReadKey();
        }

        static long Get2Compliment(long value)
        {
            if (value < 0)
            {
                return (MAX_VALUE_OF_32_BIT - Math.Abs(value));

            }
            else
            {
                return value;
            }
        }

        static void ConvertBinaryPresantation(long value, List<int> result)
        {
            if (value < 2)
            {
                result.Add((int)value);
            }
            else
            {
                long remainder;
                long quotient = Math.DivRem(value, 2, out remainder);
                result.Add((int)remainder);

                ConvertBinaryPresantation(quotient, result);
            }
        }
    }
}
