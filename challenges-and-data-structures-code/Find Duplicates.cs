using challenges_and_data_structures_code;
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
        Console.Write("duplicates element: ");
        Console.WriteLine(string.Join(", ", duplicates));
    }

    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 1, 2, 3 };

        int maxValue = arr1.Max();

        FindDuplicates(arr1, maxValue);
        Console.WriteLine("\n\n");

        int[] array1 = { 1, 2, 3, 0 };
        int[] array2 = { 2, 3, 4, 9 };
        int[] result = Class1.CommonElements(array1, array2);

        Console.WriteLine("Common elements: " + string.Join(", ", result));
    }

   
}
