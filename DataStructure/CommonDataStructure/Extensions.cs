namespace CommonDataStructure
{
    using System;
    using System.Linq;

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
    }

    public class HNode
    {
        public int frequency;
        public char data;
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

        public static Node Move(this Node node, int value)
        {
            if (node.data < value)
            {
                return node.right;
            }

            return node.left;
        }

        public static Node AvlTree(this string[] sarr)
        {
            int[] arr = sarr.Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            return arr.ToBinarySearchTree(0, arr.Length - 1);
        }


        private static Node ToBinarySearchTree(this int[] arr, int start, int end)
        {
            if (start > end)
            {
                return null;
            }

            int midIndex = (start + end) / 2;

            Node newNode = new Node();
            newNode.data = arr[midIndex];

            newNode.left = ToBinarySearchTree(arr, start, midIndex - 1);
            newNode.right = ToBinarySearchTree(arr, midIndex + 1, end);

            return newNode;
        }
    }
}
