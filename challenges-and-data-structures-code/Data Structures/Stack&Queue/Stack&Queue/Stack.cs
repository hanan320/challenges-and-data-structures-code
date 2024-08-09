using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Stack_ex
    {
        private Node top;
        public int counter = 0;
        public Stack_ex()
        { 
            top = null; 
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
            counter++;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            int data = top.Data;
            top = top.Next;
            counter--;
            return data;
        }

        public int Top()
        {
            return counter;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return top.Data;
        }
        public bool IsEmpty()
        { 
            return top == null; 
        }
       
        public void PrintStack()
        {
            Node current = top;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
        public void ReverseStack()
        {
            Queue_ex queue = new Queue_ex();


            while (!IsEmpty())
            {
                var item = Pop();
                queue.Enqueue(item);
            }
            while (queue.counter > 0)
            {
                var item = queue.Dequeue();
                Push(item);
            }
        }
        public void DeleteMiddle()
        {
            if (Top() == 0)
            {
                Console.WriteLine("Stack is empty. No element to delete.");
                return;
            }

            int middleIndex = (Top() - 1) / 2;
            Stack_ex tempStack = new Stack_ex();

            for (int i = 0; i < middleIndex; i++)
            {
                tempStack.Push(this.Pop());
            }

            if (!IsEmpty())
            {
                this.Pop();
            }

            while (tempStack.Top() > 0)
            {
                this.Push(tempStack.Pop());
            }
        }
    }
}
