using LinkedList;
using System;
using Xunit;

namespace LinkedListTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            linked_list list = new linked_list();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Act
            list.Remove(30);

            // Assert
            Assert.False(list.Includes(30));
            Assert.True(list.Includes(20));
        }

        [Fact]
        public void Test_PrintList()
        {
            // Arrange
            linked_list list = new linked_list();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            

            // Act
            string result=list.PrintList();

            // Assert
         
            Assert.Equal("5 -> 10 -> 20 -> 30 -> Null", result);
        }
    
        [Fact]
        public void TestNoDuplicates()
        {
            linked_list list = new linked_list();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            RemoveDuplicates.Remove_Duplicates(list);

            string result = list.PrintList();
            Assert.Equal("1 -> 2 -> 3 -> Null", result);
        }

        [Fact]
        public void TestRemoveOnlyDuplicates()
        {
            linked_list list = new linked_list();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(1);

            RemoveDuplicates.Remove_Duplicates(list);

            string result = list.PrintList();
            Assert.Equal("1 -> 2 -> 3 -> Null", result);
        }

        [Fact]
        public void TestAllNodesAreDuplicates()
        {
            linked_list list = new linked_list();
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.Add(7);

            RemoveDuplicates.Remove_Duplicates(list);

            string result = list.PrintList();
            Assert.Equal("7 -> Null", result);
        }

        [Fact]
        public void Merge_WhenOneListIsEmpty_ShouldReturnNonEmptyList()
        {
            // Arrange
            linked_list list1 = new linked_list();
            linked_list list2 = new linked_list();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            // Act
            linked_list mergedList = Merge_Sorted_Lists.MergeSortedLists(list1, list2);
           
            // Assert
            Assert.Equal("1 -> 2 -> 3 -> Null", mergedList.PrintList() );
        }
        [Fact]
        public void Merge_WhenBothListsAreEmpty_ShouldReturnEmptyList()
        {
            // Arrange
            linked_list list1 = new linked_list();
            linked_list list2 = new linked_list();

            // Act
            linked_list mergedList = Merge_Sorted_Lists.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Null", mergedList.PrintList());
        }
        [Fact]
        public void Merge_WhenListsAreNonEmpty_ShouldReturnMergedSortedList()
        {
            // Arrange
            linked_list list1 = new linked_list();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            linked_list list2 = new linked_list();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            // Act
            linked_list mergedList = Merge_Sorted_Lists.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", mergedList.PrintList());
        }


    }
}