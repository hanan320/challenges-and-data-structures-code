namespace Trees
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
            //AdvancedBinaryTree Btree = new AdvancedBinaryTree();
            //Btree.Root = new Node(5);
            //Btree.Root.Left = new Node(13);
            //Btree.Root.Right = new Node(7);
            //Btree.Root.Left.Left = new Node(3);
            //Btree.Root.Left.Right = new Node(7);
            //Btree.Root.Right.Left = new Node(12);
            //Btree.Root.Right.Right = new Node(20);
            //Btree.Root.Left.Left.Left = new Node(1);
            //Btree.Root.Left.Left.Right = new Node(4);
            //Btree.Root.Right.Left.Right = new Node(11);

            //Btree.Print();

            //List<int> largestValues = Btree.LargestLevelValue();
            // Output: [5, 13, 20, 11]
            //Console.WriteLine(string.Join(", ", largestValues));
            //BinaryTree Btree = new BinaryTree();
            //Btree.Root = new Node(2);
            //Btree.Root.Left = new Node(3);
            //Btree.Root.Right = new Node(5);
            //Btree.Root.Left.Left = new Node(4);
            //Btree.Root.Right.Right = new Node(6);
            //Btree.Root.Left.Left.Right = new Node(7);

            //Console.WriteLine("Right View of the Binary Tree:");
            //Btree.PrintRightView();  // Output: 2 5 6 7

            Console.WriteLine("Example 1:");
            BinaryTree Btree1 = new BinaryTree();
            Btree1.Root = new Node(1);
            Btree1.Root.Left = new Node(2);
            Btree1.Root.Right = new Node(3);
            Btree1.Root.Left.Left = new Node(4);
            Btree1.Root.Left.Right = new Node(5);
            Btree1.Root.Right.Right = new Node(6);
            Btree1.Root.Left.Left.Left = new Node(7);
            Btree1.Print();
            int maxLevel1 = Btree1.FindMaxLevelNodes(); // Using the extension method
            Console.WriteLine("Level with maximum nodes : " + maxLevel1);  // Output: 2

            Console.WriteLine("\n//////////////////////////////");
            // Example 2
            Console.WriteLine("Example 2:");
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new Node(1);
            Btree2.Root.Left = new Node(2);
            Btree2.Root.Right = new Node(3);
            Btree2.Root.Left.Left = new Node(4);
            Btree2.Root.Left.Right = new Node(5);
            Btree2.Root.Right.Right = new Node(7);
            Btree2.Root.Left.Left.Left = new Node(8);
            Btree2.Root.Left.Right.Left = new Node(9);
            Btree2.Root.Right.Right.Left = new Node(10);

            Btree2.Print();
            int maxLevel2 = Btree2.FindMaxLevelNodes(); // Using the extension method
            Console.WriteLine("Level with maximum nodes : " + maxLevel2);  

        }
    }
}
