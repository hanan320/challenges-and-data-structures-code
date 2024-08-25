﻿namespace Trees
{
    public class Program
    {
        public static void Main()
        {
            //Console.WriteLine("Binary Tree Example:");
            //BinaryTree bt = new BinaryTree();
            //bt.Root = new Node(10);
            //bt.Root.Left = new Node(5);
            //bt.Root.Right = new Node(15);
            //bt.Root.Left.Right = new Node(7);
            //bt.Root.Right.Left = new Node(8);
            //bt.Root.Right.Right = new Node(9);
            //bt.Root.Left.Left = new Node(10);
            //bt.Root.Left.Right.Right = new Node(11);

            //Console.WriteLine("PreOrder Traversal:");
            //bt.PreOrder();
            //Console.WriteLine();

            //Console.WriteLine("\nInOrder Traversal:");
            //bt.InOrder();
            //Console.WriteLine();

            //Console.WriteLine("\nPostOrder Traversal:");
            //bt.PostOrder();
            //Console.WriteLine();

            //Console.WriteLine("\nTree Structure:");
            //bt.Print();
            //Console.WriteLine();

           
            //Console.WriteLine("Binary Search Tree Example:");
            //BinarySearchTree bst = new BinarySearchTree();
            //bst.Add(10);
            //bst.Add(5);
            //bst.Add(15);
            //bst.Add(7);
            //bst.Add(8);
            //bst.Add(9);
            //bst.Add(10);
            //bst.Add(11);
            //bst.Add(2);
            //bst.Add(13);
            //bst.Add(4);

            //bool contains7 = bst.Contains(7);
            //Console.WriteLine($"Contains 7: {contains7}");

            //bst.Remove(5);
            //bool contains5 = bst.Contains(5); 
            //Console.WriteLine($"Contains 5 after removal: {contains5}");

            //Console.WriteLine("Binary Search Tree Structure:");
            //bst.Print();

            //Console.WriteLine("\n\n");
            //Console.WriteLine("////////////////////////////////////////////////////////");

           
            //MirrorBinaryTree tree = new MirrorBinaryTree();
            //tree.Root = new Node(4);
            //tree.Root.Left = new Node(8);
            //tree.Root.Right = new Node(7);
            //tree.Root.Left.Left = new Node(12);
            //tree.Root.Left.Right = new Node(9);

            //Console.WriteLine("Original Tree:");
            //tree.Print();  

            //tree.Mirror(); 

            //Console.WriteLine("Mirror Tree:");
            //tree.Print();

            //Console.WriteLine("\n\n");
            //Console.WriteLine("/////////////");


            //BinaryTreeWithSecondMax Btree = new BinaryTreeWithSecondMax();
            //Btree.Root = new Node(10);
            //Btree.Root.Left = new Node(5);
            //Btree.Root.Right = new Node(20);
            //Btree.Root.Left.Left = new Node(3);
            //Btree.Root.Left.Right = new Node(7);
            //Btree.Root.Right.Left = new Node(15);
            //Btree.Root.Right.Right = new Node(25);

            //try
            //{
            //    int secondMax = Btree.FindSecondMax();
            //    Console.WriteLine($"Second Maximum Value: {secondMax}"); // Output: 20
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

          
            //Btree.Print();

            Console.WriteLine("//////////////////////////////");
            //EnhancedBinaryTree Btree = new EnhancedBinaryTree();
            //Btree.Root = new Node(9);
            //Btree.Root.Left = new Node(8);
            //Btree.Root.Right = new Node(12);
            //Btree.Root.Left.Left = new Node(3);
            //Btree.Root.Left.Right = new Node(7);
            //Btree.Root.Right.Left = new Node(17);
            //Btree.Root.Right.Right = new Node(23);
            //Btree.Root.Left.Left.Right = new Node(4);

            //int leafSum = Btree.LeafSum(); // Output: 51
            //Console.WriteLine($"Sum of all leaf nodes: {leafSum}");
            AdvancedBinaryTree Btree = new AdvancedBinaryTree();
            Btree.Root = new Node(5);
            Btree.Root.Left = new Node(13);
            Btree.Root.Right = new Node(7);
            Btree.Root.Left.Left = new Node(3);
            Btree.Root.Left.Right = new Node(7);
            Btree.Root.Right.Left = new Node(12);
            Btree.Root.Right.Right = new Node(20);
            Btree.Root.Left.Left.Left = new Node(1);
            Btree.Root.Left.Left.Right = new Node(4);
            Btree.Root.Right.Left.Right = new Node(11);

            Btree.Print();

            List<int> largestValues = Btree.LargestLevelValue();
            // Output: [5, 13, 20, 11]
            Console.WriteLine(string.Join(", ", largestValues));

        }
    }
}
