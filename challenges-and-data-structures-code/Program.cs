using challenges_and_data_structures_code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace challenges_and_data_structures_code;
class Program
{
    
     public static void Main()
    {
        int[] arr1 = { 1, 2, 3, 1, 2, 3 };

        int maxValue = arr1.Max();

        FindDuplicates.findDuplicates (arr1, maxValue);
        Console.WriteLine("\n\n");

        int[] array1 = { 1, 2, 3, 0 };
        int[] array2 = { 2, 3, 4, 9 };
        int[] result = CommonElements.commonElements(array1, array2);

        Console.WriteLine("Common elements: " + string.Join(", ", result));
    }

   
}
