using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace treeUnitTest
{
    public class MinimumDepthTests
    {
        [Fact]
        public void Test_MinimumDepth_MultipleNodes_VaryingDepths()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);

            // Tree structure:
            //          1
            //        /   \
            //       2     3
            //      / \
            //     4   5

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(2, minDepth); // Shortest path to leaf is through the right node (1 -> 3)
        }

        [Fact]
        public void Test_MinimumDepth_EmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree(); // Empty tree, no nodes

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(0, minDepth); // The depth of an empty tree should be 0
        }

        [Fact]
        public void Test_MinimumDepth_SingleNodeTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1); // Only the root node is present

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(1, minDepth); // The minimum depth is 1 when there is only one node (the root)
        }

        
    }
}
