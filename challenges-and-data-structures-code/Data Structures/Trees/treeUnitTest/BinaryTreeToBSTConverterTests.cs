using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace treeUnitTest
{
    public class BinaryTreeToBSTConverterTests
    {
        [Fact]
        public void ConvertToBST_ProvidedExample_ShouldConvertToBST()
        {
            // Arrange
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(10);
            tree.Root.Right = new Node(50);
            tree.Root.Left.Left = new Node(5);
            tree.Root.Left.Right = new Node(30);
            tree.Root.Right.Right = new Node(60);
            tree.Root.Left.Right.Left = new Node(20);
            tree.Root.Left.Right.Right = new Node(35);

            BinaryTreeToBSTConverter converter = new BinaryTreeToBSTConverter();

            // Act
            converter.ConvertToBST(tree);

            // Assert: Validate the in-order traversal of the tree after conversion
            List<int> actualInOrderValues = GetInOrderValues(tree.Root);
            List<int> expectedInOrderValues = new List<int> { 5, 10, 20, 30, 35, 40, 50, 60 };

            Assert.Equal(expectedInOrderValues, actualInOrderValues);
        }

        // Test Case 2: Test a tree with nodes only on one side
        [Fact]
        public void ConvertToBST_OnlyRightSide_ShouldConvertToBST()
        {
            // Arrange: Tree with only right nodes
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(10);
            tree.Root.Right = new Node(20);
            tree.Root.Right.Right = new Node(30);
            tree.Root.Right.Right.Right = new Node(40);

            BinaryTreeToBSTConverter converter = new BinaryTreeToBSTConverter();

            // Act
            converter.ConvertToBST(tree);

            // Assert: Validate in-order traversal (should already be in sorted order)
            List<int> actualInOrderValues = GetInOrderValues(tree.Root);
            List<int> expectedInOrderValues = new List<int> { 10, 20, 30, 40 };

            Assert.Equal(expectedInOrderValues, actualInOrderValues);
        }

        [Fact]
        public void ConvertToBST_OnlyLeftSide_ShouldConvertToBST()
        {
            // Arrange: Tree with only left nodes
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(40);
            tree.Root.Left = new Node(30);
            tree.Root.Left.Left = new Node(20);
            tree.Root.Left.Left.Left = new Node(10);

            BinaryTreeToBSTConverter converter = new BinaryTreeToBSTConverter();

            // Act
            converter.ConvertToBST(tree);

            // Assert: Validate in-order traversal (should be sorted after conversion)
            List<int> actualInOrderValues = GetInOrderValues(tree.Root);
            List<int> expectedInOrderValues = new List<int> { 10, 20, 30, 40 };

            Assert.Equal(expectedInOrderValues, actualInOrderValues);
        }

        // Helper method to get in-order values of a tree
        private List<int> GetInOrderValues(Node node)
        {
            List<int> values = new List<int>();
            InOrderTraversal(node, values);
            return values;
        }

        // In-order traversal to collect node values
        private void InOrderTraversal(Node node, List<int> values)
        {
            if (node == null) return;
            InOrderTraversal(node.Left, values);
            values.Add(node.Data);
            InOrderTraversal(node.Right, values);
        }
    }
}
