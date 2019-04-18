using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree
    {
        private Node root { get; set; }

        public int height()
        {
            throw new NotImplementedException();
        }
        public int count()
        {
            throw new NotImplementedException();
        }
        private int countRecursive(Node n)
        {
            throw new NotImplementedException();
        }
        public void insert(char c)
        {
            if (root == null)
            {
                root = new Node(c);
            }
            else
            {
                insert(root, c);
            }
        }
        private void insert(Node n, char c)
        {
            if (c >= n.Value && n.RightChild == null)
            {
                n.RightChild = new Node(c);
                return;
            }
            if (c < n.Value && n.LeftChild == null)
            {
                n.LeftChild = new Node(c);
                return;
            }
            if (c >= n.Value)
            {
                insert(n.RightChild, c);
            }
            else if (c < n.Value)
            {
                insert(n.LeftChild, c);
            }
        }
        public bool remove(char c)
        {
            throw new NotImplementedException();
        }
        private bool remove(Node n, char c)
        {
            throw new NotImplementedException();
        }
        public bool search(char c)
        {
            throw new NotImplementedException();
        }
        private bool search(Node n, char c)
        {
            throw new NotImplementedException();
        }
        public void balance()
        {

        }
        public void preorderprint()
        {

        }
        private void preorderprint(Node n)
        {

        }
        public void inorderprint()
        {

        }
        private void inorderprint(Node n)
        {

        }
        public void postorderprint()
        {

        }
        private void postorderprint(Node n)
        {

        }
        public void print()
        {
            BinaryTreePrinter.printNode(root);
        }
    }
}
