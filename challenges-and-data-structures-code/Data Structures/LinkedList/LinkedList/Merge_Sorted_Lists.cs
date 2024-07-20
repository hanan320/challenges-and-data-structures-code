using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Merge_Sorted_Lists
    {
        public static linked_list MergeSortedLists(linked_list list1, linked_list list2)
        {
            Node dummy = new Node(0);
            Node tail = dummy;

            Node current1 = list1.head;
            Node current2 = list2.head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data <= current2.Data)
                {
                    tail.Next = current1;
                    current1 = current1.Next;
                }
                else
                {
                    tail.Next = current2;
                    current2 = current2.Next;
                }
                tail = tail.Next;
            }

            if (current1 != null)
            {
                tail.Next = current1;
            }

            if (current2 != null)
            {
                tail.Next = current2;
            }

            linked_list mergedList = new linked_list();
            mergedList.head = dummy.Next;
            return mergedList;
        }
       
    }
}
