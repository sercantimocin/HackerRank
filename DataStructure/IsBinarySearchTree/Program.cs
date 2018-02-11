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

            List<int> countedRecords = new List<int>();
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                Node current = q.Dequeue();

                if (countedRecords.Contains(current.data))
                {
                    return false;
                }
                countedRecords.Add(current.data);

                Node left = current.left;
                Node right = current.right;

                if (left != null)
                {
                    if (current.data <= left.data)
                    {
                        return false;
                    }
                    q.Enqueue(left);
                }

                if (right != null)
                {
                    if (current.data >= right.data)
                    {
                        return false;
                    }
                    q.Enqueue(right);
                }
            };

            return true;
        }
    }
}
