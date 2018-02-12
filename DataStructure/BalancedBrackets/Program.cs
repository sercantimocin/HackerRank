using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedBrackets
{
    using System.Collections;

    class Program
    {
        static void Main(string[] args)
        {
        }

        static string isBalanced(string text)
        {
            Stack<char> s = new Stack<char>();

            foreach (char c in text.ToCharArray())
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    s.Push(c);
                }
                else
                {
                    char popedChar = s.Pop();

                    if ((popedChar == '(' && c == ')')|| (popedChar == '[' && c == ']') || (popedChar == '{' && c == '}'))
                    {
                        return "No";
                    }
                }
            }

            return "Yes";
        }
    }
}


//static String isBalanced(String s)
//{
//    Stack<Character> s = new Stack<>();

//    for (Character c: )
//}