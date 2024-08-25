using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class AdvancedBinaryTree:BinaryTree
    {
        public List<int> LargestLevelValue() 
        { 
            List<int> largestValues = new List<int>();

            if (Root == null)
                return largestValues;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {   
                int levelSize = queue.Count;
                int max = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();
                    if (currentNode.Data > max)
                    {
                        max = currentNode.Data;
                    }
                    if (currentNode.Left != null)
                    { 
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);

                    }
                }
                largestValues.Add(max);
            }
            return largestValues;
        }
    }
}
