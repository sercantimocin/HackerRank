namespace LevelOrderTraversal
{
    using System;
    using System.Collections.Generic;

    using CommonDataStructure;

    class Program
    {


        static void Main(string[] args)
        {
            Node node = null;

            node = "1 2 5 3 6 4".Split(' ').ConvertToTree();
            node = "5 3 10 2 4 7 12 8".Split(' ').ConvertToTree();
            node = "1 2 3 4".Split(' ').ConvertToTree();
            node = "5 4 7 3 9 8".Split(' ').ConvertToTree();

            LevelOrder(node);

            Console.ReadKey();
        }

        static void LevelOrder(Node root)
        {
            Queue<int> queue = new Queue<int>();

            if (root != null)
            {
                queue.Enqueue(root.data);
            }

            LevelOrderTraversal(root, queue);

            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue() + " ");
            }
        }

        static void LevelOrderTraversal(Node root, Queue<int> queue)
        {
            if (root != null)
            {
                Node leftNode = root.left;
                if (leftNode != null)
                {
                    queue.Enqueue(leftNode.data);
                }
                
                Node rightNode = root.right;
                if (rightNode != null)
                {
                    queue.Enqueue(rightNode.data);
                }

                LevelOrderTraversal(leftNode, queue);
                LevelOrderTraversal(rightNode, queue);
            }
        }
    }
}


//void levelOrder(Node root)
//{

//    Queue<Integer> queue = new ArrayDeque<Integer>();

//    if (root != null)
//    {
//        queue.add(root.data);
//    }

//    LevelOrderTraversal(root, queue);

//    while (queue.size() > 0)
//    {
//        System.out.print(queue.remove() + " ");
//    }
//}

//void LevelOrderTraversal(Node root, Queue<Integer> queue)
//{
//    if (root != null)
//    {
//        Node leftNode = root.left;
//        if (leftNode != null)
//        {
//            queue.add(leftNode.data);
//        }

//        Node rightNode = root.right;
//        if (rightNode != null)
//        {
//            queue.add(rightNode.data);
//        }

//        LevelOrderTraversal(leftNode, queue);
//        LevelOrderTraversal(rightNode, queue);
//    }
//}
