using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsExploration
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var charArray = text.ToCharArray();

            int changedCharCount = 0;

            for (int i = 0; i < charArray.Length; i=i+3)
            {
                if (charArray[i]!='S')
                {
                    changedCharCount++;
                }
                if (charArray[i+1] != 'O')
                {
                    changedCharCount++;
                }
                if (charArray[i+2] != 'S')
                {
                    changedCharCount++;
                }
            }

            Console.WriteLine(changedCharCount);
        }
    }
}
