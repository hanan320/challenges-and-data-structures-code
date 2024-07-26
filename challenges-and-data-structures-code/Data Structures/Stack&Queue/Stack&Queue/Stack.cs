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
        {top = null;}
        public void Push(int data)
        {Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
            counter++;}

        public int Pop()
        {if (IsEmpty()){
         throw new InvalidOperationException("Stack is empty."); }
            int data = top.Data;
            top = top.Next;
            counter--;
            return data;}
        public int Peek()
        {if (IsEmpty()){
         throw new InvalidOperationException("Stack is empty.");}
            return top.Data;}
        public bool IsEmpty()
        {return top == null;}
        public int countIndexes()
        {return counter; }
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
    }
}
