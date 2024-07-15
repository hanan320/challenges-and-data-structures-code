using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class RemoveDuplicates
    {
        
            public static void Remove_Duplicates(linked_list list)
            {
                Node current = list.head;

                while (current != null && current.Next != null)
                {
                    Node runner = current;

                    while (runner.Next != null)
                    {
                        if (runner.Next.Data == current.Data)
                        {

                            runner.Next = runner.Next.Next;
                        }
                        else
                        {
                            runner = runner.Next;
                        }
                    }
                    current = current.Next;
                }
            }
        }

    
}
