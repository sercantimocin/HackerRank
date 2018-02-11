using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBinarySearchTree
{
    using CommonDataStructure;

    class Program
    {
        static void Main(string[] args)
        {

            Node root = null;
            root = "1 3 2 1".Split(' ').ConvertToTree();
            //no
            root = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 17 16 18 19 20 21 22 23 24 25 26 27 28 29 30 31".Split(' ').ConvertToTree();



            Console.WriteLine(CheckBst(root));
            Console.ReadKey();
        }

        static bool CheckBst(Node root)
        {
            if (root == null)
            {
                return false;
            }

            return isBst(root, int.MinValue, int.MaxValue);

        }

        static bool isBst(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.data >= min && root.data <= max)
            {
                return isBst(root.left, min, root.data - 1) && isBst(root.right, root.data + 1, max);
            }
            else
            {
                return false;
            }
        }
    }
}


//boolean checkBST(Node root)
//{
//    if (root == null)
//    {
//        return false;
//    }

//    return isBst(root, Integer.MIN_VALUE,
//                       Integer.MAX_VALUE);
//}

//boolean isBst(Node root, int min, int max)
//{
//    if (root == null)
//    {
//        return true;
//    }

//    if (root.data >= min && root.data <= max)
//    {
//        return isBst(root.left, min, root.data - 1) && isBst(root.right, root.data + 1, max);
//    }
//    else
//    {
//        return false;
//    }
//}
