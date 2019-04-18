using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public char Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Height
        {
            get
            {
                int LeftTreeeHeight = 0;
                int RightTreeeHeight = 0;

                if (LeftChild != null)
                {
                    LeftTreeeHeight = LeftChild.Height + 1;
                }
                if (RightChild != null)
                {
                    RightTreeeHeight = RightChild.Height + 1;
                }
                if (LeftTreeeHeight > RightTreeeHeight)
                {
                    return LeftTreeeHeight;
                }
                else
                {
                    return RightTreeeHeight;
                }
            }
        }

        public Node(char val)
        {
            Value = val;
        }
    }
}
