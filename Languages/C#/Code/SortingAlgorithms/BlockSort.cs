using System;

namespace SortingAlgorithms
{
    public static class BlockSort
    {
        public static void Sort(int[] arrayToSort, int blockSize)
        {
            int arrayLength = arrayToSort.Length;
            int numberOfBlocks = (int)Math.Ceiling((double)arrayLength / blockSize);

            // Step 1: Sort each block using QuickSort
            for (int i = 0; i < numberOfBlocks; i++)
            {
                int blockStart = i * blockSize;
                int blockEnd = Math.Min(blockStart + blockSize - 1, arrayLength - 1);
                QuickSort.Sort(arrayToSort, blockStart, blockEnd);
            }

            // Step 2: Merge sorted blocks using Merge
            for (int size = blockSize; size < arrayLength; size *= 2)
            {
                for (int leftIndex = 0; leftIndex < arrayLength - 1; leftIndex += 2 * size)
                {
                    int middleIndex = Math.Min(leftIndex + size - 1, arrayLength - 1);
                    int rightIndex = Math.Min(leftIndex + 2 * size - 1, arrayLength - 1);

                    Merge(arrayToSort, leftIndex, middleIndex, rightIndex);
                }
            }
        }

        private static void Merge(int[] arrayToSort, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftSize = middleIndex - leftIndex + 1;
            int rightSize = rightIndex - middleIndex;

            // Create temporary arrays to hold the values of the left and right sub-arrays
            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            // Copy data to temporary arrays leftArray[] and rightArray[]
            Array.Copy(arrayToSort, leftIndex, leftArray, 0, leftSize);
            Array.Copy(arrayToSort, middleIndex + 1, rightArray, 0, rightSize);

            // Merge the temporary arrays back into arrayToSort[leftIndex..rightIndex]
            int i = 0, j = 0;
            int k = leftIndex;
            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arrayToSort[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arrayToSort[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            // Copy the remaining elements of leftArray[], if any
            while (i < leftSize)
            {
                arrayToSort[k] = leftArray[i];
                i++;
                k++;
            }

            // Copy the remaining elements of rightArray[], if any
            while (j < rightSize)
            {
                arrayToSort[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
