using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListRotator
    {

        private linked_list _list;

        public LinkedListRotator(linked_list list)
        {
            _list = list;
        }

        // Rotate the linked list to the left by k places
        public void RotateLeft(int k)
        {
            if (_list.head == null || k == 0)
            {
                return;
            }

            // Step 1: Calculate the length of the linked list
            Node current = _list.head;
            int length = 1;
            while (current.Next != null)
            {
                current = current.Next;
                length++;
            }

            // Step 2: Handle cases where k >= length
            k = k % length;
            if (k == 0) return; // No need to rotate if k is 0 or k is a multiple of the length

            // Step 3: Find the k-th node and the last node
            Node lastNode = current; // current is now at the last node
            current = _list.head;

            // Traverse to the (k-1)-th node
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }

            // Step 4: Rotate the list
            Node newHead = current.Next; // New head will be the k-th node
            current.Next = null;         // Break the list at the k-th position
            lastNode.Next = _list.head;  // Connect the last node to the original head
            _list.head = newHead;        // Update the head to the new head
        }
    }
}
