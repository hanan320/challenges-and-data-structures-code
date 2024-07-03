using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures_code
{
    public class CommonElements {


        public static int[] commonElements(int[] array1, int[] array2)
        {
            int max1 = FindMaxValue(array1);
            int max2 = FindMaxValue(array2);
            int maxPossible = Math.Max(max1, max2);

            int[] freq1 = new int[maxPossible + 1];
            int[] freq2 = new int[maxPossible + 1];

            PopulateFrequency(freq1, array1);
            PopulateFrequency(freq2, array2);

            List<int> commonElements = new List<int>();
            for (int i = 0; i <= maxPossible; i++)
            {
                if (freq1[i] > 0 && freq2[i] > 0)
                {
                    commonElements.Add(i);
                }
            }

            return commonElements.ToArray();
        }
        public static int FindMaxValue(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentException("Array must not be empty or null.");
            }

            int max = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        private static void PopulateFrequency(int[] freq, int[] arr)
        {
            foreach (int num in arr)
            {
                freq[num]++;
            }
        }
    }

    }

