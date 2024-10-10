using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTreeToBSTConverter
    {
        public void ConvertToBST(BinaryTree tree)
        {
            if (tree == null || tree.Root == null)
            {
                Console.WriteLine("The tree is empty or null!");
                return;
            }

            // Step 1: Collect in-order traversal values from the binary tree
            List<int> values = new List<int>();
            StoreInOrderValues(tree.Root, values);

            // Step 2: Sort the collected values
            values.Sort();

            // Step 3: Reassign the sorted values back to the tree using in-order traversal
            int index = 0;
            ReassignValues(tree.Root, values, ref index);
        }

        // Helper method to store in-order traversal values of the tree
        private void StoreInOrderValues(Node node, List<int> values)
        {
            if (node == null) return;

            StoreInOrderValues(node.Left, values);  // Traverse left subtree
            values.Add(node.Data);                 // Store node's value
            StoreInOrderValues(node.Right, values); // Traverse right subtree
        }

        // Helper method to reassign sorted values back to the tree
        private void ReassignValues(Node node, List<int> values, ref int index)
        {
            if (node == null) return;

            ReassignValues(node.Left, values, ref index);  // Traverse left subtree

            node.Data = values[index++];  // Reassign value from sorted list

            ReassignValues(node.Right, values, ref index);  // Traverse right subtree
        }
    }
}
