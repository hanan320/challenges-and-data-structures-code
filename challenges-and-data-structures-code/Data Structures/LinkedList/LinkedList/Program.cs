namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            linked_list list = new linked_list();
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            
            list.PrintList(); 

           
            list.Remove(10);
            list.PrintList();
        }
    }
}
