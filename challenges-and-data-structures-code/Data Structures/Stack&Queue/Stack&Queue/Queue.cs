using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    public class Queue_ex
    {
        private Node front;
        private Node rear;
        public int counter = 0;

        public Queue_ex()
        {
            front = rear = null;
        }

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (IsEmpty())
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            counter++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            int data = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            counter--;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }
            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
        public int countIndexes()
        {
            return counter;
        }

        public void PrintQueue()
        {
            Node current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
