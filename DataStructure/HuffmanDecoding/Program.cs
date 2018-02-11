using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanDecoding
{
    using CommonDataStructure;

    class Program
    {
        static void Main(string[] args)
        {
        }

        void Decode(string S, Node root)
        {

            Node current = root;
            char[] encodedChars = S.ToCharArray();

            foreach (char encodedChar in encodedChars)
            {
                if (encodedChar == '0')
                {
                    current = current.left;
                }
                else
                {
                    current = current.right;
                }

                if (current.data != '\0')
                {
                    Console.Write(current.data);
                    current = root;
                }
            }
        }
    }
}
