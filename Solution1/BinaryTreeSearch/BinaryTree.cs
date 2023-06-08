using System;

namespace BinaryTreeSearch
{
    class BinaryTree
    {
        private Node root;

        public void Add(string data)
        {
            root = AddNode(root, data);
        }

        private Node AddNode(Node current, string data)
        {
            if (current == null)
            {
                return new Node(data);
            }

            if (string.Compare(data, current.Data, StringComparison.Ordinal) < 0)
            {
                current.Left = AddNode(current.Left, data);
            }
            else
            {
                current.Right = AddNode(current.Right, data);
            }

            return current;
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        private void TraverseInOrder(Node node)
        {
            if (node == null)
            {
                return;
            }

            TraverseInOrder(node.Left);
            Console.WriteLine(node.Data);
            TraverseInOrder(node.Right);
        }
    }
}