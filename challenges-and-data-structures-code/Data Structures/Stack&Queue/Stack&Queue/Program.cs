using System;
namespace Stack_Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("stack:");
            Stack_ex stack = new Stack_ex();
            stack.Push(10); // Stack: Top -> 10
            stack.Push(5);  // Stack: Top -> 5 -> 10
            stack.PrintStack(); // Output: 5 10
            Console.WriteLine("\n");

            int popped = stack.Pop(); // popped: 5
            Console.WriteLine($"Popped: {popped}");
            Console.Write("stack:");
            stack.PrintStack(); // Output: 10
            Console.WriteLine("\n");

            int peekedStack = stack.Peek(); // peeked: 10
            Console.WriteLine($"Peeked: {peekedStack}");

            bool isStackEmpty = stack.IsEmpty(); // isEmpty: false
            Console.WriteLine($"Is stack empty? {isStackEmpty}");
            Console.WriteLine("\n");

            Console.WriteLine("\nQueue operations:");
            Queue_ex queue = new Queue_ex();
            queue.Enqueue(10); // Queue: 10
            queue.Enqueue(5);  // Queue: 10 -> 5
            queue.PrintQueue(); // Output: 10 5
            Console.WriteLine("\n");

            int dequeued = queue.Dequeue(); // dequeued: 10
            Console.WriteLine($"Dequeued: {dequeued}");
            Console.Write("queue:");
            queue.PrintQueue(); // Output: 5
            Console.WriteLine("\n");

            int peekedQueue = queue.Peek(); // peeked: 5
            Console.WriteLine($"Peeked: {peekedQueue}");

            bool isQueueEmpty = queue.IsEmpty(); // isEmpty: false
            Console.WriteLine($"Is queue empty? {isQueueEmpty}");

            Console.WriteLine("\n\n");
            Stack_ex stack1 = new Stack_ex();
            stack1.Push(10);
            stack1.Push(5);
            stack1.Push(15);
            stack1.Push(20);
            Console.WriteLine("before reverse");
            stack1.PrintStack();

            stack1.ReverseStack();
            Console.WriteLine("after reverse");
            stack1.PrintStack();

            Stack_ex stack2 = new Stack_ex();
            stack2.Push(7);
            stack2.Push(14);
            stack2.Push(3);
            stack2.Push(8);
            stack2.Push(5);
            Console.WriteLine("\ndelete middle element:");
            Console.WriteLine("before delete");
            stack2.PrintStack();

            stack2.DeleteMiddle();
            Console.WriteLine("after delete");
            stack2.PrintStack();

           

            stack2.Push(2);
            stack2.Push(9);
            stack2.Push(11);

            Console.WriteLine("before delete");
            stack2.PrintStack();

            stack2.DeleteMiddle();
            Console.WriteLine("after delete");
            stack2.PrintStack();


            MinStack minStack = new MinStack();

            // Push elements onto the stack
            minStack.Push(15); // Stack: 15 (min: 15)
            minStack.Push(7);  // Stack: 7 -> 15 (min: 7)
            minStack.Push(12); // Stack: 12 -> 7 -> 15 (min: 7)
            minStack.Push(3);  // Stack: 3 -> 12 -> 7 -> 15 (min: 3)

            // Print the current stack
            Console.WriteLine("\nPrint the stack:");
            minStack.PrintStack(); // Expected Output: Top -> 3 -> 12 -> 7 -> 15

            // Get and display the minimum element
            Console.WriteLine($"\nGet the minimum element: {minStack.GetMin()}"); // Expected min: 3

            // Pop a node from the stack
            Console.WriteLine("\nPop a node from the stack:");
            int poppedValue = minStack.Pop(); // Popped: 3
            Console.WriteLine($"The popped element is: {poppedValue}");
            minStack.PrintStack(); // Expected Output: Top -> 12 -> 7 -> 15

            // Get and display the new minimum element
            Console.WriteLine($"\nGet the new minimum element: {minStack.GetMin()}"); // Expected min: 7

            // Peek the top node of the stack
            Console.WriteLine($"\nPeek the top node: {minStack.Peek()}"); // Display the top element

            // Push another element onto the stack
            Console.WriteLine("\nPush another element:");
            minStack.Push(2);  // Stack: 2 -> 12 -> 7 -> 15 (min: 2)
            minStack.PrintStack(); // Expected Output: Top -> 2 -> 12 -> 7 -> 15

            // Get and display the new minimum element
            Console.WriteLine($"\nGet the new minimum element: {minStack.GetMin()}"); // Expected min: 2

            // Check and display if the stack is empty
            Console.WriteLine("\nCheck if the stack is empty:");
            bool isEmpty = minStack.IsEmpty(); // isEmpty: false
            Console.WriteLine($"Is the stack empty: {isEmpty}");
        

        }
    }
}
