using Trees;

namespace treeUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PreOrder_Traversal_Returns_Correct_Order()
        {
            // Arrange
            var bt = new BinaryTree();
            bt.Root = new Node(10);
            bt.Root.Left = new Node(5);
            bt.Root.Right = new Node(15);
            bt.Root.Left.Right = new Node(7);

            // Act
            var result = CaptureOutput(() => bt.PreOrder());

            // Assert
            Assert.Equal("10 5 7 15 ", result);
        }

        [Fact]
        public void InOrder_Traversal_Returns_Correct_Order()
        {
            // Arrange
            var bt = new BinaryTree();
            bt.Root = new Node(10);
            bt.Root.Left = new Node(5);
            bt.Root.Right = new Node(15);
            bt.Root.Left.Right = new Node(7);

            // Act
            var result = CaptureOutput(() => bt.InOrder());

            // Assert
            Assert.Equal("5 7 10 15 ", result);
        }

        [Fact]
        public void PostOrder_Traversal_Returns_Correct_Order()
        {
            // Arrange
            var bt = new BinaryTree();
            bt.Root = new Node(10);
            bt.Root.Left = new Node(5);
            bt.Root.Right = new Node(15);
            bt.Root.Left.Right = new Node(7);

            // Act
            var result = CaptureOutput(() => bt.PostOrder());

            // Assert
            Assert.Equal("7 5 15 10 ", result);
        }

        private string CaptureOutput(Action action)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                action();
                return sw.ToString();
            }
        }
        [Fact]
        public void Add_Node_Adds_Correctly()
        {
            // Arrange
            var bst = new BinarySearchTree();

            // Act
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            // Assert
            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
            Assert.True(bst.Contains(7));
        }

        [Fact]
        public void Contains_Node_Returns_True_If_Present()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            // Act
            var result = bst.Contains(5);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Remove_Node_Removes_Correctly()
        {
            // Arrange
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            // Act
            bst.Remove(5);

            // Assert
            Assert.False(bst.Contains(5));
            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(15));
            Assert.True(bst.Contains(7));
        }
    }
}