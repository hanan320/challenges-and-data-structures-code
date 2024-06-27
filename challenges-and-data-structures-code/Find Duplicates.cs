using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void FindDuplicates(int[] arr, int max)
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

        Console.WriteLine(string.Join(", ", duplicates));
    }

    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 1, 2, 3 };

        int maxValue = arr1.Max();

        FindDuplicates(arr1, maxValue);
    }
}
