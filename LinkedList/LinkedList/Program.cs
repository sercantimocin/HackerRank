using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
        }

        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }


        static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep, TextWriter textWriter)
        {
            while (node != null)
            {
                textWriter.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    textWriter.Write(sep);
                }
            }
        }

        static void Main(string[] args)
        {
            //var list = new DoublyLinkedList();
            //list.InsertNode(1);
            //list.InsertNode(2);
            //list.InsertNode(3);

            //reverse(list.head);

            var a = new int[] { 4, 3, 1, 2 };
            minimumSwaps(a);
        }

        static DoublyLinkedListNode reverse(DoublyLinkedListNode head)
        {

            if (head == null)
            {
                return null;
            }

            if (head.next == null)
            {
                return head;
            }

            var previous = head;
            var current = previous.next;

            previous.prev = previous.next;
            previous.next = null;

            while (current != null)
            {
                current.prev = current.next;
                current.next = previous;

                previous = current;
                current = current.prev;
            }

            return head;

        }

        static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {

            var s1 = new Stack<int>();
            var c1 = head1.next;
            while (c1 != null)
            {
                s1.Push(c1.data);
                c1 = c1.next;
            }

            var s2 = new Stack<int>();
            var c2 = head2.next;
            while (c2 != null)
            {
                s2.Push(c2.data);
                c2 = c2.next;
            }

            int result = s1.Count > s2.Count ? s1.Peek() : s2.Peek();

            while (s1.Count > 0 && s2.Count > 0)
            {
                var d1 = s1.Pop();
                var d2 = s2.Pop();

                if (d1 == d2)
                {
                    result = d1;
                }
                else
                {
                    return result;
                }
            }

            return result;
        }


        //bool has_cycle(Node* head)
        //{

        //    if (head == NULL || head->next == NULL)
        //    {
        //        return false;
        //    }

        //    Node* p1 = head;
        //    int counter = 0;

        //    while (p1 != NULL)
        //    {
        //        counter++;
        //        if (counter > 100)
        //        {
        //            return true;
        //        }

        //        p1 = p1->next;
        //    }

        //    return false;
        //}

        //V1
        //static int minimumSwaps(int[] arr)
        //{

        //    int swapCount = 0;
        //    int min = Int32.MaxValue;
        //    int minIndex = -1;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //            minIndex = i;
        //        }
        //    }

        //    if (minIndex > 0)
        //    {
        //        int t = arr[0];
        //        arr[0] = arr[minIndex];
        //        arr[minIndex] = t;
        //        swapCount++;
        //    }

        //    for (int i = 1; i < arr.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < arr.Length; j++)
        //        {
        //            if (arr[j] == min + i)
        //            {
        //                if (j != i)
        //                {
        //                    int t = arr[i];
        //                    arr[i] = arr[j];
        //                    arr[j] = t;
        //                    swapCount++;
        //                }
        //            }
        //        }
        //    }

        //    return swapCount;
        //}

        // https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        //V2
        static int minimumSwaps(int[] arr)
        {

            int swapCount = 0;
            int min = Int32.MaxValue;
            int minIndex = -1;
            var arrDic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
                arrDic.Add(arr[i], i);
            }

            if (minIndex > 0)
            {
                int t = arr[0];
                arr[0] = arr[minIndex];
                arr[minIndex] = t;
                swapCount++;
                arrDic[arr[minIndex]] = minIndex;
            }

            for (int i = 1; i < arr.Length - 1; i++)
            {
                int j = arrDic[min + i];

                if (j != i)
                {
                    int t = arr[i];
                    arr[i] = arr[j];
                    arr[j] = t;
                    swapCount++;
                    arrDic[arr[j]] = j;
                }
            }

            return swapCount;
        }

    }
}
