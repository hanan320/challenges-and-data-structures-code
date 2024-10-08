﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        // Pre-order traversal: Root, Left, Right
        public void PreOrder()
        {
            PreOrder(Root);
        }

        private void PreOrder(Node node)
        {
            if (node == null) return;
            Console.Write(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        // In-order traversal: Left, Root, Right
        public void InOrder()
        {
            InOrder(Root);
        }

        private void InOrder(Node node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        // Post-order traversal: Left, Right, Root
        public void PostOrder()
        {
            PostOrder(Root);
        }

        private void PostOrder(Node node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }

        // Print the tree in a structured way
        public void Print()
        {
            Print(Root, 0);
        }

        private void Print(Node node, int level)
        {
            if (node == null) return;
            Print(node.Right, level + 1);
            Console.WriteLine(new string(' ', level * 4) + node.Data);
            Print(node.Left, level + 1);
        }
        public void PrintRightView()
        {
            if (Root == null)
            {
                Console.WriteLine("The tree is empty.");
                return;
            }

           
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;

                // Iterate over each level
                for (int i = 0; i < levelSize; i++)
                {
                    Node currentNode = queue.Dequeue();

                    // Only print the rightmost node (i == levelSize - 1)
                    if (i == levelSize - 1)
                    {
                        Console.Write(currentNode.Data + " ");
                    }

                    // Enqueue left child first, then right child
                    if (currentNode.Left != null)
                    {
                        queue.Enqueue(currentNode.Left);
                    }
                    if (currentNode.Right != null)
                    {
                        queue.Enqueue(currentNode.Right);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
