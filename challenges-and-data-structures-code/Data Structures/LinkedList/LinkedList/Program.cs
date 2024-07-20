namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            linked_list list = new linked_list();
            list.Add(5);
            list.Add(20);
            list.Add(20);
            list.Add(10);
            list.Add(5);
            list.Add(10);

            Console.WriteLine("Original List:");
            list.PrintList();

            RemoveDuplicates.Remove_Duplicates(list);

            Console.WriteLine("List After Removing Duplicates:");
            list.PrintList();

            linked_list list1 = new linked_list();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            linked_list list2 = new linked_list();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            Console.WriteLine("list 1: ");
            list1.PrintList();
            Console.WriteLine("list 2: ");
            list2.PrintList();

            linked_list mergedList =  Merge_Sorted_Lists.MergeSortedLists(list1, list2);
            Console.WriteLine("Merged List:");
            mergedList.PrintList();



           
        }
    }
}
