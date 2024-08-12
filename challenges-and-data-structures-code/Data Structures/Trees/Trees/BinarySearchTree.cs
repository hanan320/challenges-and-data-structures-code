using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        // Add a node with the specified data
        public void Add(int data)
        {
            Root = Add(Root, data);
        }

        private Node Add(Node node, int data)
        {
            if (node == null)
            {
                return new Node(data);
            }

            if (data < node.Data)
            {
                node.Left = Add(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = Add(node.Right, data);
            }

            return node;
        }

        // Check if a node with the specified data exists
        public bool Contains(int data)
        {
            return Contains(Root, data);
        }

        private bool Contains(Node node, int data)
        {
            if (node == null)
            {
                return false;
            }

            if (data < node.Data)
            {
                return Contains(node.Left, data);
            }
            else if (data > node.Data)
            {
                return Contains(node.Right, data);
            }
            else
            {
                return true;
            }
        }

        // Remove a node with the specified data
        public void Remove(int data)
        {
            Root = Remove(Root, data);
        }

        private Node Remove(Node node, int data)
        {
            if (node == null)
            {
                return null;
            }

            if (data < node.Data)
            {
                node.Left = Remove(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = Remove(node.Right, data);
            }
            else
            {
                if (node.Left == null)
                {
                    return node.Right;
                }
                else if (node.Right == null)
                {
                    return node.Left;
                }

                Node minLargerNode = GetMin(node.Right);
                node.Data = minLargerNode.Data;
                node.Right = Remove(node.Right, minLargerNode.Data);
            }

            return node;
        }

        private Node GetMin(Node node)
        {
            while (node.Left != null)
            {
                node = node.Left;
            }
            return node;
        }

        //print metho
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
    }
}
