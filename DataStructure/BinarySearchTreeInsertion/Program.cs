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
            bool isRight;

            do
            {
                previous = current;

                if (current.data < value)
                {
                    current = current.right;
                    isRight = true;
                }
                else
                {
                    current = current.left;
                    isRight = false;
                }

                if (current == null)
                {
                    var newNode = new Node();
                    newNode.data = value;

                    if (isRight)
                    {
                        previous.right = newNode;
                    }
                    else
                    {
                        previous.left = newNode;
                    }
                }

            } while (current != null);

            return root;
        }

    }
}
