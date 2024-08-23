using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class EnhancedBinaryTree:BinaryTree
    {
        public int LeafSum()
        { return LeafSumHelper(Root);  }

        private int LeafSumHelper(Node node)
        {
            if (node == null)
            {
                return 0;
            }

           
            if (node.Left == null && node.Right == null)
            {
                return node.Data;
            }

           
            return LeafSumHelper(node.Left) + LeafSumHelper(node.Right);
        }
    }
}
