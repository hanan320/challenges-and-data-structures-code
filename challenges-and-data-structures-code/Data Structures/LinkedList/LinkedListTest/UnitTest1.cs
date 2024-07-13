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

            // Redirect console output to a string
            var consoleOutput = new System.IO.StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            list.PrintList();

            // Assert
            string expectedOutput = "Head -> 5 -> 10 -> 20 -> 30 -> Null" + Environment.NewLine;
            Assert.Equal(expectedOutput, consoleOutput.ToString());
        }
    }
}