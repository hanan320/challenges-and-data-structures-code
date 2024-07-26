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
        }
    }
}
