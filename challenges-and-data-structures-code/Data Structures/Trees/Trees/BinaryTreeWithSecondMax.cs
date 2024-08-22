using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTreeWithSecondMax : BinaryTree
    {
       
        public int FindSecondMax()
        {
            if (Root == null)
                throw new InvalidOperationException("Tree is empty.");

            return FindSecondMax(Root, int.MinValue, int.MinValue);
        }

        private int FindSecondMax(Node node, int max, int secondMax)
        {
            if (node == null)
                return secondMax;

            if (node.Data > max)
            {
                secondMax = max;
                max = node.Data;
            }
            else if (node.Data > secondMax && node.Data < max)
            {
                secondMax = node.Data;
            }

            secondMax = FindSecondMax(node.Left, max, secondMax);
            secondMax = FindSecondMax(node.Right, max, secondMax);

            if (secondMax == int.MinValue)
                throw new InvalidOperationException("Tree does not have a second maximum value.");

            return secondMax;
        }
    }
}
