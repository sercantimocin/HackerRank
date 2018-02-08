namespace TopView
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CommonDataStructure;

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter tree nodes");
            //var input = Console.ReadLine().Split(' ');
            string[] input = "2 1 10 3 4 5 6 11".Split(' ');

            Node node = input.ConvertToTree();
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
    }



    public class ExtendedNode : Node
    {
        public int HorDepth;
        public int VertDepth;
    }
}
