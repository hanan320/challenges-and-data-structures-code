using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   

    public class linked_list
    {
        public Node head;

        public linked_list()
        {
            head = null;
        }

        // Add a new node to the end of the list
        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Check if the linked list contains a node with the specified value
        public bool Includes(int data)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        // Remove the first node with the specified data from the linked list
        public void Remove(int data)
        {
            try
            {
                if (head == null)
                {
                    throw new InvalidOperationException("List is empty");
                }

                if (head.Data == data)
                {
                    head = head.Next;
                    return;
                }

                Node current = head;
                Node previous = null;

                while (current != null && current.Data != data)
                {
                    previous = current;
                    current = current.Next;
                }

                if (current == null)
                {
                    throw new InvalidOperationException("Data not found in the list");
                }

                previous.Next = current.Next;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Print the contents of the list in order
        public void PrintList()
        {
            Node current = head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next; // Move to the next node
            }
            Console.WriteLine("Null");
        }


    }

}
