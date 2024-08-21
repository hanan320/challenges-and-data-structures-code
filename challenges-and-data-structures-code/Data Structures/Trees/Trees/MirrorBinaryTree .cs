using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class MirrorBinaryTree : BinaryTree
    {
        public void Mirror()
        {
            Mirror(Root);
        }
        private void Mirror(Node node)
        {
            if (node == null)
                return;

            Mirror(node.Left);
            Mirror(node.Right);

            Node temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;
        }
    }
}
