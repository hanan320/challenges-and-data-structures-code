namespace Trees
{
    public class Program
    {
        public static void Main()
        {
            // Binary Tree Example
            Console.WriteLine("Binary Tree Example:");
            BinaryTree bt = new BinaryTree();
            bt.Root = new Node(10);
            bt.Root.Left = new Node(5);
            bt.Root.Right = new Node(15);
            bt.Root.Left.Right = new Node(7);
            bt.Root.Right.Left = new Node(8);
            bt.Root.Right.Right = new Node(9);
            bt.Root.Left.Left = new Node(10);
            bt.Root.Left.Right.Right=new Node(11);

            Console.WriteLine("PreOrder Traversal:");
            bt.PreOrder();
            Console.WriteLine();

            Console.WriteLine("\nInOrder Traversal:");
            bt.InOrder();
            Console.WriteLine();

            Console.WriteLine("\nPostOrder Traversal:");
            bt.PostOrder();
            Console.WriteLine();

            Console.WriteLine("\nTree Structure:");
            bt.Print();
            Console.WriteLine();

            // Binary Search Tree Example
            Console.WriteLine("Binary Search Tree Example:");
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);
            bst.Add(8);
            bst.Add(9);
            bst.Add(10);
            bst.Add(11);
            bst.Add(2);
            bst.Add(13);
            bst.Add(4);

            bool contains7 = bst.Contains(7); // contains: true
            Console.WriteLine($"Contains 7: {contains7}");

            bst.Remove(5);
            bool contains5 = bst.Contains(5); // contains: false
            Console.WriteLine($"Contains 5 after removal: {contains5}");

            Console.WriteLine("Binary Search Tree Structure:");
           bst.Print();
        }
    }
}
