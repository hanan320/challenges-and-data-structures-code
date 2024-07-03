namespace Find_Duplicates
{
    public class Program
    {
        public static void findDuplicates(int[] arr, int max)
        {
            int[] frequency = new int[max + 1];

            foreach (int i in arr)
            {
                frequency[i]++;
            }

            List<int> duplicates = new List<int>();
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 1)
                {
                    duplicates.Add(i);
                }
            }
            Console.Write("duplicates element: ");
            Console.WriteLine(string.Join(", ", duplicates));
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 1, 2, 3 };

            int maxValue = arr1.Max();

            findDuplicates(arr1, maxValue);
            
        }
    }
}
        