﻿namespace TopView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter tree nodes");
            //var input = Console.ReadLine().Split(' ');
            string[] input = "2 1 10 3 4 5 6 11".Split(' ');

            Node node = ConvertToTree<int>(input);
            //Traversal(node);

            TopView(node);

            Console.ReadKey();
        }

        static void TopView(Node root)
        {
            List<ExtendedNode> topView = new List<ExtendedNode>();

            OrderalTraversal(root, 0, 0, topView);

            foreach (var item in topView)
            {
                Console.Write(item.data + " ");
            }

        }

        static void OrderalTraversal(Node root, int horizontalDepth, int verticalDepth, List<ExtendedNode> topView)
        {
            if (root != null)
            {
                int leftHorDepth = horizontalDepth - 1;
                int rightHorDepth = horizontalDepth + 1;
                int newVerticalDepth = verticalDepth + 1;

                OrderalTraversal(root.left, leftHorDepth, newVerticalDepth, topView);

                if (topView.Any(x => x.HorDepth == horizontalDepth))
                {
                    ExtendedNode item = topView.FirstOrDefault(x => x.HorDepth == horizontalDepth && x.VertDepth > verticalDepth);
                    if (item != null)
                    {
                        item.data = root.data;
                    }
                }
                else
                {
                    topView.Add(new ExtendedNode() { data = root.data, HorDepth = horizontalDepth, VertDepth = verticalDepth });
                }

                OrderalTraversal(root.right, rightHorDepth, newVerticalDepth, topView);
            }
        }

        private static Node ConvertToTree<T>(string[] array) where T : struct
        {
            Node root = new Node();
            root.data = Convert.ToInt32(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                var itemVal = (T)Convert.ChangeType(array[i], typeof(T));
                var itemValInt = (int)(object)itemVal;

                Node newNode = new Node { data = itemValInt };
                AddNewNode(ref root, newNode);
            }

            return root;
        }

        private static void AddNewNode(ref Node current, Node newNode)
        {
            if (current == null)
            {
                current = newNode;
            }
            else
            {
                if (current.data > newNode.data)
                {
                    AddNewNode(ref current.left, newNode);
                }
                else
                {
                    AddNewNode(ref current.right, newNode);
                }
            }
        }

        static void Traversal(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data);

                Traversal(node.left);
                Traversal(node.right);
            }
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

    public class ExtendedNode : Node
    {
        public int HorDepth;
        public int VertDepth;
    }
}
