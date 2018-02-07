namespace TopView
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter tree nodes");
            var input = Console.ReadLine().Split(' ');

            Node node = ConvertToTree<int>(input);
            //Traversal(node);

            TopView(node);

            Console.ReadKey();
        }

        static void TopView(Node root)
        {
            Dictionary<int, int> topView = new Dictionary<int, int>();

            OrderalTraversal(root, 0, topView);

            foreach (var item in topView)
            {
                Console.Write(item.Value + " ");
            }

        }

        static void OrderalTraversal(Node root, int depth, Dictionary<int, int> topView)
        {
            if (root != null)
            {
                int leftDepth = depth - 1;
                int rightDepth = depth + 1;

                OrderalTraversal(root.left, leftDepth, topView);

                if (topView.ContainsKey(depth))
                {
                    topView[depth] = root.data;
                }
                else
                {
                    topView.Add(depth,root.data);
                }

                OrderalTraversal(root.right, rightDepth, topView);
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
}
