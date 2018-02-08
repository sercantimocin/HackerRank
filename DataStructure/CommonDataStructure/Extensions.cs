﻿namespace CommonDataStructure
{
    using System;

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

    public static class Extensions
    {
        public static Node ConvertToTree(this string[] array)
        {
            Node root = new Node();
            root.data = Convert.ToInt32(array[0]);

            for (int i = 1; i < array.Length; i++)
            {

                Node newNode = new Node { data = Convert.ToInt32(array[i]) };
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

        public static void Traversal(this Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.data);

                Traversal(node.left);
                Traversal(node.right);
            }
        }

        public static Node Move(this Node node,int value)
        {
            if (node.data < value)
            {
                return node.right;
            }

            return node.left;
        }
    }
}
