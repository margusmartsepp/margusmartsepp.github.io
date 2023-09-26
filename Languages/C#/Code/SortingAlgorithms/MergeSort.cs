using System;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] numbersToSort, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;

                // Recursively sort the first and second halves
                Sort(numbersToSort, leftIndex, middleIndex);
                Sort(numbersToSort, middleIndex + 1, rightIndex);

                // Merge the sorted halves
                Merge(numbersToSort, leftIndex, middleIndex, rightIndex);
            }
        }

        private static void Merge(int[] numbersToSort, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftSize = middleIndex - leftIndex + 1;
            int rightSize = rightIndex - middleIndex;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            Array.Copy(numbersToSort, leftIndex, leftArray, 0, leftSize);
            Array.Copy(numbersToSort, middleIndex + 1, rightArray, 0, rightSize);

            int i = 0, j = 0;
            int k = leftIndex;

            while (i < leftSize && j < rightSize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    numbersToSort[k] = leftArray[i];
                    i++;
                }
                else
                {
                    numbersToSort[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftSize)
            {
                numbersToSort[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightSize)
            {
                numbersToSort[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
