using System;

namespace SortingAlgorithms
{
    public static class CountingSort
    {
        public static void Sort(int[] inputArray)
        {
            int maxValue = inputArray[0];
            int minValue = inputArray[0];
            int range, index = 0;

            // Find the maximum and minimum values in the array
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] > maxValue)
                    maxValue = inputArray[i];
                if (inputArray[i] < minValue)
                    minValue = inputArray[i];
            }

            range = maxValue - minValue + 1;
            int[] countArray = new int[range];

            // Count the occurrences of each element
            for (int i = 0; i < inputArray.Length; i++)
            {
                countArray[inputArray[i] - minValue]++;
            }

            // Place the elements back into the original array in sorted order
            for (int i = minValue; i <= maxValue; i++)
            {
                for (int j = 0; j < countArray[i - minValue]; j++)
                {
                    inputArray[index++] = i;
                }
            }
        }
    }
}
