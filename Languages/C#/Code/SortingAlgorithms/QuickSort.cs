using System;

namespace SortingAlgorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] numbersToSort, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int pivotIndex = Partition(numbersToSort, startIndex, endIndex);

                // Recursively sort the elements before and after partition
                Sort(numbersToSort, startIndex, pivotIndex);
                Sort(numbersToSort, pivotIndex + 1, endIndex);
            }
        }

        private static int Partition(int[] numbersToSort, int startIndex, int endIndex)
        {
            int pivotValue = numbersToSort[endIndex];
            int smallerElementIndex = startIndex;

            for (int currentIndex = startIndex; currentIndex < endIndex; currentIndex++)
            {
                if (numbersToSort[currentIndex] < pivotValue)
                {
                    // Swap smallerElementIndex and currentIndex
                    int temp = numbersToSort[smallerElementIndex];
                    numbersToSort[smallerElementIndex] = numbersToSort[currentIndex];
                    numbersToSort[currentIndex] = temp;

                    smallerElementIndex++;
                }
            }

            // Swap smallerElementIndex and endIndex (or pivot)
            int swapTemp = numbersToSort[smallerElementIndex];
            numbersToSort[smallerElementIndex] = numbersToSort[endIndex];
            numbersToSort[endIndex] = swapTemp;

            return smallerElementIndex;
        }
    }
}
