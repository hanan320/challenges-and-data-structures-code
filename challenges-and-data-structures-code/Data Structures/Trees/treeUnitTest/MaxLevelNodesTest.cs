using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees;

namespace treeUnitTest
{
    public class MaxLevelNodesTest
    {
        // Test 1: Check if the correct level with maximum nodes is found using the first example.
        [Fact]
        public void FindMaxLevelNodes_ShouldReturnCorrectLevel_ForExample1()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(6);
            Btree.Root.Left.Left.Left = new Node(7);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, maxLevel);  // Expecting level 2 to have the maximum number of nodes
        }

        // Test 2: Test with a tree having multiple levels with the same maximum number of nodes.
        [Fact]
        public void FindMaxLevelNodes_ShouldReturnCorrectLevel_ForTreeWithSameMaxNodesOnMultipleLevels()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new Node(1);
            Btree.Root.Left = new Node(2);
            Btree.Root.Right = new Node(3);
            Btree.Root.Left.Left = new Node(4);
            Btree.Root.Left.Right = new Node(5);
            Btree.Root.Right.Right = new Node(7);
            Btree.Root.Left.Left.Left = new Node(8);
            Btree.Root.Left.Right.Left = new Node(9);
            Btree.Root.Right.Right.Left = new Node(10);

            // Act
            int maxLevel = Btree.FindMaxLevelNodes();

            // Assert
            Assert.Equal(2, maxLevel);  // Expecting level 2 to be returned because it's the smallest level with the maximum number of nodes
        }
    }
}
