using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public static class BinaryTreeFindMinimumDepth
    {
        public static int FindMinimumDepth(this BinaryTree tree)
        {
            if (tree.Root == null)
                return 0;

            Queue<(Node, int)> queue = new Queue<(Node, int)>();
            queue.Enqueue((tree.Root, 1));  // Start with the root node at depth 1

            while (queue.Count > 0)
            {
                var (currentNode, currentDepth) = queue.Dequeue();

                // Check if it's a leaf node (no children)
                if (currentNode.Left == null && currentNode.Right == null)
                    return currentDepth;

                // Add left and right children to the queue with updated depth
                if (currentNode.Left != null)
                    queue.Enqueue((currentNode.Left, currentDepth + 1));

                if (currentNode.Right != null)
                    queue.Enqueue((currentNode.Right, currentDepth + 1));
            }

            return 0;  // In case the tree is empty
        }
    }
}
