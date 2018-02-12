using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleDetection
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
        }

        static void Main(string[] args)
        {

        }

        bool CheckHasCycle(Node node)
        {
            List<Node> oldNodes = new List<Node>();

            while (node != null)
            {
                if (oldNodes.Contains(node))
                {
                    return true;
                }

                oldNodes.Add(node);
                node = node.next;
            }

            return false;
        }
    }
}

//boolean hasCycle(Node head)
//{

//    List<Node> oldNodes = new ArrayList();

//    while (head != null)
//    {
//        if (oldNodes.contains(head))
//        {
//            return true;
//        }

//        oldNodes.add(head);
//        head = head.next;
//    }

//    return false;

//}

