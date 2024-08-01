using Stack_Queue;

namespace Stack_QueueTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestPush()
        {
            Stack_ex stack = new Stack_ex();
            stack.Push(10);
            Assert.Equal(10, stack.Peek());
        }   

        [Fact]
        public void TestPop()
        {
            Stack_ex stack = new Stack_ex();
            stack.Push(10);
            stack.Push(5);
            int popped = stack.Pop();
            Assert.Equal(5, popped);
        }

        [Fact]
        public void TestIsEmptyStack()
        {
            Stack_ex stack = new Stack_ex();
            Assert.True(stack.IsEmpty());
            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }

        [Fact]
        public void TestEnqueue()
        {
            Queue_ex queue = new Queue_ex();
            queue.Enqueue(10);
            Assert.Equal(10, queue.Peek());
        }

        [Fact]
        public void TestDequeue()
        {
            Queue_ex queue = new Queue_ex();
            queue.Enqueue(10);
            queue.Enqueue(5);
            int dequeued = queue.Dequeue();
            Assert.Equal(10, dequeued);
        }

        [Fact]
        public void TestIsEmptyQueue()
        {
            Queue_ex queue = new Queue_ex();
            Assert.True(queue.IsEmpty());
            queue.Enqueue(10);
            Assert.False(queue.IsEmpty());
        }

        [Fact]
        public void ReverseStack_WithMultipleElements_ReversesCorrectly()
        {
            Stack_ex stack = new Stack_ex();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(5, stack.Pop());
        }
        [Fact]
        public void ReverseStack_WithOneElement_ReversesCorrectly()
        {
            Stack_ex stack = new Stack_ex();
            stack.Push(1);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
        }
        [Fact]
        public void ReverseStack_WithEmptyStack_DoesNothing()
        {
            Stack_ex stack = new Stack_ex();

            stack.ReverseStack();

            Assert.True(stack.IsEmpty());
        }
    }
}