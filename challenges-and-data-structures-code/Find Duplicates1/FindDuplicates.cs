using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class FindDuplicates
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

}
