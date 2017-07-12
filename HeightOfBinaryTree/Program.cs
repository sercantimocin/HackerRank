using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightOfBinaryTree
{
    class Program
    {
        class Node
        {
            internal Node left;

            internal Node right;
            int data;

            Node(int data)
            {
                this.data = data;
                left = null;
                right = null;
            }
        }

        static void Main(string[] args)
        {
        }

        static int height(Node root)
        {

            int lheight = 0;
            int rheight = 0;

            if (root.left == null && root.right == null)
            {
                return 0;
            }

            if (root.left != null)
            {
                lheight = height(root.left) + 1;
            }

            if (root.right != null)
            {
                rheight = height(root.right) + 1;
            }

            if (lheight < rheight)
            {
                return rheight;
            }
            else
            {
                return lheight;
            }
        }
    }
}
