using System;

namespace SortingAlgorithms
{
    public static class StoogeSort
    {
        public static void Sort(int[] arrayToSort, int lowerIndex, int upperIndex)
        {
            if (lowerIndex >= upperIndex)
                return;

            // Swap if the element at lower index is greater than the element at upper index
            if (arrayToSort[lowerIndex] > arrayToSort[upperIndex])
            {
                int temp = arrayToSort[lowerIndex];
                arrayToSort[lowerIndex] = arrayToSort[upperIndex];
                arrayToSort[upperIndex] = temp;
            }

            // If there are more than 2 elements in the array
            if (upperIndex - lowerIndex + 1 > 2)
            {
                int third = (upperIndex - lowerIndex + 1) / 3;

                // Recursively sort the first two-thirds, last two-thirds, and first two-thirds again
                Sort(arrayToSort, lowerIndex, upperIndex - third);
                Sort(arrayToSort, lowerIndex + third, upperIndex);
                Sort(arrayToSort, lowerIndex, upperIndex - third);
            }
        }
    }
}
