using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public static class BinaryTreeFindMaxLevelNodes
    {
        public static int FindMaxLevelNodes(this BinaryTree tree)
        {
            if (tree.Root == null)
            {
                return -1; // Return -1 if the tree is empty
            }

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(tree.Root);

            int maxNodes = 0;
            int maxLevel = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelNodeCount = queue.Count; // Number of nodes at the current level

                // Update maxNodes and maxLevel if this level has more nodes
                if (levelNodeCount > maxNodes)
                {
                    maxNodes = levelNodeCount;
                    maxLevel = currentLevel;
                }

                // Process all nodes at the current level
                for (int i = 0; i < levelNodeCount; i++)
                {
                    Node currentNode = queue.Dequeue();

                    // Add left and right children to the queue for the next level
                    if (currentNode.Left != null)
                        queue.Enqueue(currentNode.Left);

                    if (currentNode.Right != null)
                        queue.Enqueue(currentNode.Right);
                }

                currentLevel++; // Move to the next level
            }

            return maxLevel; // Return the level with the maximum number of nodes
        }
    }
}
