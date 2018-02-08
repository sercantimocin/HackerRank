using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeInsertion
{
    using System.Runtime.CompilerServices;

    using CommonDataStructure;

    class Program
    {

        static void Main(string[] args)
        {
            string[] arr = "4 2 7 1 3".Split(' ');

            Node root = arr.ConvertToTree();

            var r = Insert(root, 6);

            r.Traversal();
        }


        static Node Insert(Node root, int value)
        {
            Node previous = root;
            Node current = root;

            Node newNode = new Node();
            newNode.data = value;

            if (root == null)
            {
                root = newNode;
                return root;
            }

            do
            {
                previous = current;

                if (current.data < value)
                {
                    current = current.right;
                    if (current == null)
                    {
                        previous.right = newNode;
                    }

                }
                else
                {
                    current = current.left;
                    if (current == null)
                    {
                        previous.left = newNode;
                    }
                }

            } while (current != null);

            return root;
        }

    }
}
