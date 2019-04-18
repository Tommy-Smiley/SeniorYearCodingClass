using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binarytree = new BinaryTree();
            binarytree.insert('q');
            binarytree.insert('w');
            binarytree.insert('e');
            binarytree.insert('r');
            binarytree.insert('t');
            binarytree.insert('y');
            binarytree.insert('u');
            binarytree.insert('i');
            binarytree.print();
            Console.ReadKey();

        }
    }
}
