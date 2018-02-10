namespace LevelOrderTraversal
{
    using System;
    using System.Collections.Generic;

    using CommonDataStructure;

    internal class Program
    {


        private static void Main(string[] args)
        {
            Node node = null;

            node = "1 2 5 3 6 4".Split(' ').ConvertToTree();
            //node = "5 3 10 2 4 7 12 8".Split(' ').ConvertToTree();
            //node = "1 2 3 4".Split(' ').ConvertToTree();
            //node = "5 4 7 3 9 8".Split(' ').ConvertToTree();

            LevelOrder(node);

            Console.ReadKey();
        }

        private static void LevelOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);


            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                Console.Write(current.data + " ");

                Node leftNode = current.left;
                if (leftNode != null)
                {
                    queue.Enqueue(leftNode);
                }

                Node rightNode = current.right;
                if (rightNode != null)
                {
                    queue.Enqueue(rightNode);
                }
            }
        }
    }
}


//void levelOrder(Node root)
//{

//    if (root == null)
//    {
//        return;
//    }

//    Queue<Node> q = new LinkedList();
//    q.add(root);

//    while (!q.isEmpty())
//    {
//        Node current = q.remove();
//        System.out.print(current.data + " ");

//        if (current.left != null)
//        {
//            q.add(current.left);
//        }

//        if (current.right != null)
//        {
//            q.add(current.right);
//        }
//    }
//}
