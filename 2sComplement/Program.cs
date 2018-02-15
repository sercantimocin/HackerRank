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

            int val = -1;

            Console.WriteLine(ConvertBinaryPresantation(val));
            Console.ReadKey();
        }

        static int ConvertBinaryPresantation(int value)
        {
            long newVal = value;
            if (value < 0)
            {
                newVal = (long)(Math.Pow(2, 32) - Math.Abs(value));
            }

            if (newVal < 2)
            {
                return (int)newVal;
            }
            else
            {
                int quotient = (int)(newVal / 2);
                int remainder = (int)(newVal % 2);

                return ConvertBinaryPresantation(quotient) + remainder;
            }
        }
    }
}

//import java.io.*;
//import java.util.*;
//import java.text.*;
//import java.math.*;
//import java.util.regex.*;

//public class Solution
//{

//    public static void main(String[] args)
//    {
//        Scanner in = new Scanner(System.in);
//        int m = in.nextInt();

//        Integer[][] inputs = new Integer[m][2];

//        for (int i = 0; i < m; i++)
//        {
//            inputs[i][0] = in.nextInt();
//            inputs[i][1] = in.nextInt();
//        }

//        for (int i = 0; i < m; i++)
//        {
//            int countOfOnes = 0;

//            for (int j = inputs[i][0]; j <= inputs[i][1]; j++)
//            {
//                countOfOnes += ConvertBinaryPresantation(j);
//            }

//            System.out.println(countOfOnes);
//        }

//    }

//    static int ConvertBinaryPresantation(int value)
//    {
//        long newVal = value;
//        if (value < 0)
//        {
//            newVal = (long)(Math.pow(2, 32) - Math.abs(value));
//        }

//        return Long.bitCount(newVal);
//    }
//}
