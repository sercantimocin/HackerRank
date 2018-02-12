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

                    if ((popedChar == '(' && c != ')') || (popedChar == '[' && c != ']') || (popedChar == '{' && c != '}'))
                    {
                        return "NO";
                    }
                }
            }

            return "YES";
        }
    }
}


//static String isBalanced(String text)
//{

//    if (text == null && text.trim().isEmpty())
//    {
//        return "NO";
//    }

//    Stack<Character> s = new Stack();

//    for (Character c : text.toCharArray())
//    {
//        if (c == '(' || c == '[' || c == '{')
//        {
//            s.push(c);
//        }
//        else if (c == ')' || c == ']' || c == '}')
//        {
//            if (s.size() == 0)
//            {
//                return "NO";
//            }

//            char popedChar = s.pop();

//            if ((popedChar == '(' && c != ')') || (popedChar == '[' && c != ']') || (popedChar == '{' && c != '}'))
//            {
//                return "NO";
//            }
//        }
//    }

//    if (s.size() == 0)
//    {
//        return "YES";
//    }

//    return "NO";
//}