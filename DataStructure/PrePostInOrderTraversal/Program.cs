namespace PreorderTraversal
{
    using System;

    class Program
    {
        class Node
        {
            internal int data;

            internal Node left;

            internal Node right;
        }

        static void Main(string[] args)
        {
            var root = new Node()
                           {
                               data = 1,
                               left = null,
                               right =
                                   new Node()
                                       {
                                           data = 2,
                                           left = null,
                                           right =
                                               new Node()
                                                   {
                                                       data = 5,
                                                       left =
                                                           new Node()
                                                               {
                                                                   data = 3,
                                                                   left = null,
                                                                   right =
                                                                       new Node()
                                                                           {
                                                                               data = 4,
                                                                               left = null,
                                                                               right = null
                                                                           }
                                                               },
                                                       right =
                                                           new Node()
                                                               {
                                                                   data = 6,
                                                                   left = null,
                                                                   right = null
                                                               }
                                                   }
                                       }
                           };

            preOrder(root);
            Console.WriteLine();
            postOrder(root);
            Console.ReadKey();
        }

        static void preOrder(Node root)
        {
            Console.Write(root.data + " ");

            if (root.left != null)
            {
                preOrder(root.left);
            }

            if (root.right != null)
            {
                preOrder(root.right);
            }
        }

        static void postOrder(Node root)
        {
            if (root.left != null)
            {
                postOrder(root.left);
            }

            if (root.right != null)
            {
                postOrder(root.right);
            }

            Console.Write(root.data + " ");
        }

        static void inOrder(Node root)
        {
            if (root.left != null)
            {
                inOrder(root.left);
            }

            Console.Write(root.data + " ");

            if (root.right != null)
            {
                inOrder(root.right);
            }
        }

    }
}
