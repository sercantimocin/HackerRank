using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LowestCommonAncestor
{
    using System.ComponentModel.Design.Serialization;

    using CommonDataStructure;

    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            root = "4 2 7 1 3 6".Split(' ').ConvertToTree();
            //root = "20 10 30 39 50 29 60 38".Split(' ').ConvertToTree();
            LowestCommon(root, 1, 3);
            //LowestCommon(root, 50, 10);

            Console.ReadKey();
        }

        private static void LowestCommon(Node root, int v1, int v2)
        {
            if (root == null)
            {
                return;
            }

            List<Node> arry1 = GetDistance(root, v1);
            List<Node> arry2 = GetDistance(root, v2);

            Node match = null;

            foreach (Node a1 in arry1)
            {
                foreach (Node a2 in arry2)
                {
                    if (a1.data == a2.data)
                    {
                        match = a1;
                    }
                }
            }

            Console.WriteLine(match.data);
        }


        static List<Node> GetDistance(Node root, int value)
        {
            List<Node> results = new List<Node>();

            if (root != null)
            {
                int index = 0;
                Node current = root;

                while (true)
                {
                    results.Add(current);

                    if (current.data == value)
                    {
                        break;
                    }

                    if (current.data > value)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
            }

            return results;
        }
    }
}


//static Node lca(Node root, int v1, int v2)
//{
//    if (root == null)
//    {
//        return null;
//    }

//    List<Node> arry1 = GetDistance(root, v1);
//    List<Node> arry2 = GetDistance(root, v2);

//    Node match = null;

//    for (Node a1 : arry1)
//    {
//        for (Node a2 : arry2)
//        {
//            if (a1.data == a2.data)
//            {
//                match = a1;
//            }
//        }
//    }

//    return match;
//}

//static List<Node> GetDistance(Node root, int value)
//{
//    List<Node> results = new ArrayList<Node>();

//    if (root != null)
//    {
//        Node current = root;

//        while (true)
//        {
//            results.add(current);

//            if (current.data == value)
//            {
//                break;
//            }

//            if (current.data > value)
//            {
//                current = current.left;
//            }
//            else
//            {
//                current = current.right;
//            }
//        }
//    }

//    return results;
//}