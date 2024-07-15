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
        }
    }
}
