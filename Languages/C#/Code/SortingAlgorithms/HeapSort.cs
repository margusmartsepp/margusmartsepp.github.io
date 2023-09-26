using System;

namespace SortingAlgorithms
{
    public static class HeapSort
    {
        public static void Sort(int[] numbersToSort)
        {
            int arraySize = numbersToSort.Length;

            // Build max heap
            for (int i = arraySize / 2 - 1; i >= 0; i--)
            {
                Heapify(numbersToSort, arraySize, i);
            }

            // Extract elements from heap one by one
            for (int i = arraySize - 1; i >= 0; i--)
            {
                // Move current root to end
                int temp = numbersToSort[0];
                numbersToSort[0] = numbersToSort[i];
                numbersToSort[i] = temp;

                // Heapify the reduced heap
                Heapify(numbersToSort, i, 0);
            }
        }

        private static void Heapify(int[] numbersToSort, int arraySize, int rootIndex)
        {
            int largestElementIndex = rootIndex;
            int leftChildIndex = 2 * rootIndex + 1;
            int rightChildIndex = 2 * rootIndex + 2;

            if (leftChildIndex < arraySize && numbersToSort[leftChildIndex] > numbersToSort[largestElementIndex])
            {
                largestElementIndex = leftChildIndex;
            }

            if (rightChildIndex < arraySize && numbersToSort[rightChildIndex] > numbersToSort[largestElementIndex])
            {
                largestElementIndex = rightChildIndex;
            }

            if (largestElementIndex != rootIndex)
            {
                int swap = numbersToSort[rootIndex];
                numbersToSort[rootIndex] = numbersToSort[largestElementIndex];
                numbersToSort[largestElementIndex] = swap;

                // Heapify the affected sub-tree
                Heapify(numbersToSort, arraySize, largestElementIndex);
            }
        }
    }
}
