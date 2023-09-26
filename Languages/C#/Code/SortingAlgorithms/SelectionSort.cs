using System;

namespace SortingAlgorithms
{
    public static class SelectionSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int arrayLength = arrayToSort.Length;

            for (int currentIndex = 0; currentIndex < arrayLength - 1; currentIndex++)
            {
                int minElementIndex = currentIndex;

                for (int nextIndex = currentIndex + 1; nextIndex < arrayLength; nextIndex++)
                {
                    if (arrayToSort[nextIndex] < arrayToSort[minElementIndex])
                    {
                        minElementIndex = nextIndex;
                    }
                }

                // Swap arrayToSort[minElementIndex] and arrayToSort[currentIndex]
                int temp = arrayToSort[minElementIndex];
                arrayToSort[minElementIndex] = arrayToSort[currentIndex];
                arrayToSort[currentIndex] = temp;
            }
        }
    }
}
