using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesRansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
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
//        int n = in.nextInt();
//        String magazine[] = new String[m];
//        for (int magazine_i = 0; magazine_i < m; magazine_i++)
//        {
//            magazine[magazine_i] = in.next();
//        }
//        String ransom[] = new String[n];
//        for (int ransom_i = 0; ransom_i < n; ransom_i++)
//        {
//            ransom[ransom_i] = in.next();
//        }

//        Map<String, Integer> map = new HashMap();

//        for (String rword : ransom)
//        {
//            int y = map.get(rword) + 1;
//            map.put(rword, y);
//        }

//        for (String mword : magazine)
//        {
//            if (map.get(mword) == 0)
//            {
//                System.out.print("No");
//                break;
//            }
//            else
//            {
//                int y = map.get(mword) - 1;
//                map.put(mword, y);
//            }

//        }

//        System.out.print("Yes");
//    }
//}
