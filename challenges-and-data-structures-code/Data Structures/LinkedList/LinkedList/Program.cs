﻿namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //linked_list list = new linked_list();
            //list.Add(5);
            //list.Add(20);
            //list.Add(20);
            //list.Add(10);
            //list.Add(5);
            //list.Add(10);

            //Console.WriteLine("Original List:");
            //list.PrintList();

            //RemoveDuplicates.Remove_Duplicates(list);

            //Console.WriteLine("\nList After Removing Duplicates:");
            //Console.WriteLine(list.PrintList()); 

            //linked_list list1 = new linked_list();
            //list1.Add(1);
            //list1.Add(3);
            //list1.Add(5);

            //linked_list list2 = new linked_list();
            //list2.Add(2);
            //list2.Add(4);
            //list2.Add(6);

            //Console.WriteLine("\nlist 1: ");
            //Console.WriteLine(list1.PrintList()); 
            //Console.WriteLine("\nlist 2: ");
            //Console.WriteLine(list2.PrintList()); 

            //linked_list mergedList =  Merge_Sorted_Lists.MergeSortedLists(list1, list2);
            //Console.WriteLine("\nMerged List:");
            //Console.WriteLine(mergedList.PrintList());

            linked_list list1 = new linked_list();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);

            Console.WriteLine("Original List:");
            Console.WriteLine(list1.PrintList());

            LinkedListRotator rotator1 = new LinkedListRotator(list1);
            rotator1.RotateLeft(2);
            Console.WriteLine("Rotated List (k=2):");
            Console.WriteLine(list1.PrintList());

          
            linked_list list2 = new linked_list();
            list2.Add(10);
            list2.Add(20);
            list2.Add(30);
            list2.Add(40);
            list2.Add(50);

            Console.WriteLine("\nOriginal List:");
            Console.WriteLine(list2.PrintList());

            LinkedListRotator rotator2 = new LinkedListRotator(list2);
            rotator2.RotateLeft(3);
            Console.WriteLine("Rotated List (k=3):");
            Console.WriteLine(list2.PrintList());


        }
    }
}
