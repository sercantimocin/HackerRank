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
            var list = new DoublyLinkedList();
            list.InsertNode(1);
            list.InsertNode(2);
            list.InsertNode(3);

            reverse(list.head);
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
    }
}
