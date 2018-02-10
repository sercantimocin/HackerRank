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
            Node root = "4 2 7 1 3 6".Split(' ').ConvertToTree();
            LowestCommon(root, 1, 7);

            Console.ReadKey();
        }

        private static void LowestCommon(Node root, int v1, int v2)
        {
            if (root == null)
            {
                return;
            }

            int firstDataDistance = GetDistance(root, v1);
            int secondDataDistance = GetDistance(root, v2);

            int totalDistance = 0;

            if ((firstDataDistance < 0 && secondDataDistance < 0) || (firstDataDistance > 0 && secondDataDistance > 0))
            {
                totalDistance = Math.Abs(firstDataDistance - secondDataDistance);
            }
            else
            {
                totalDistance = Math.Abs(firstDataDistance) + Math.Abs(secondDataDistance);
            }

            decimal averageDistance = (decimal)totalDistance / 2;
            int roundedDistance = (int)Math.Ceiling(averageDistance);

            Node r = null;

            if (Math.Abs(firstDataDistance) >= roundedDistance)
            {
                r = GetNode(root, v1, roundedDistance);
            }
            else
            {
                r = GetNode(root, v2, roundedDistance);
            }

            Console.WriteLine(r.data);
        }


        static int GetDistance(Node root, int value)
        {
            int result = 0;

            if (root != null)
            {
                if (root.data == value)
                {
                    return 0;
                }

                if (root.data > value)
                {
                    result = GetDistance(root.left, value) - 1;
                }
                else
                {
                    result = GetDistance(root.right, value) + 1;
                }
            }

            return result;
        }

        static Node GetNode(Node root, int value, int distance)
        {
            Node current = root;

            if (root != null)
            {
                do
                {
                    if (current.data > value)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current = current.right;
                    }

                    if (current.data == value)
                    {
                        current = root;
                        break;
                    }

                    distance = distance - 1;

                }
                while (distance > 0);
            }

            return current;
        }
    }
}


//static Node lca(Node root, int v1, int v2)
//{
//    if (root == null)
//    {
//        return root;
//    }

//    int firstDataDistance = GetDistance(root, v1);
//    int secondDataDistance = GetDistance(root, v2);

//    int totalDistance = 0;

//    if ((firstDataDistance < 0 && secondDataDistance < 0) || (firstDataDistance > 0 && secondDataDistance > 0))
//    {
//        totalDistance = Math.abs(firstDataDistance - secondDataDistance);
//    }
//    else
//    {
//        totalDistance = Math.abs(firstDataDistance) + Math.abs(secondDataDistance);
//    }

//    double averageDistance = (double)totalDistance / 2;
//    int roundedDistance = (int)Math.ceil(averageDistance);

//    Node r = null;

//    if (Math.abs(firstDataDistance) >= roundedDistance)
//    {
//        r = GetNode(root, v1, roundedDistance);
//    }
//    else
//    {
//        r = GetNode(root, v2, roundedDistance);
//    }

//    return r;
//}

//static int GetDistance(Node root, int value)
//{
//    int result = 0;

//    if (root != null)
//    {
//        if (root.data == value)
//        {
//            return 0;
//        }

//        if (root.data > value)
//        {
//            result = GetDistance(root.left, value) - 1;
//        }
//        else
//        {
//            result = GetDistance(root.right, value) + 1;
//        }
//    }

//    return result;
//}

//static Node GetNode(Node root, int value, int distance)
//{
//    Node current = root;

//    if (root != null)
//    {
//        do
//        {
//            if (current.data > value)
//            {
//                current = current.left;
//            }
//            else
//            {
//                current = current.right;
//            }

//            if (current.data == value)
//            {
//                current = root;
//                break;
//            }

//            distance = distance - 1;

//        }
//        while (distance > 0);
//    }

//    return current;
//}
