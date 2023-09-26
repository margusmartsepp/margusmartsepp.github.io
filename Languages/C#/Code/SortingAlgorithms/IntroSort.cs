using System;

namespace SortingAlgorithms
{
    public static class IntroSort
    {
        public static void Sort(int[] arrayToSort, int lowerBound, int upperBound)
        {
            int arraySize = upperBound - lowerBound;
            if (arraySize < 16)
            {
                // Reuse existing InsertionSort
                InsertionSort.Sort(arrayToSort, lowerBound, upperBound);
            }
            else if (arraySize > 1)
            {
                int partitionIndex = Partition(arrayToSort, lowerBound, upperBound);
                Sort(arrayToSort, lowerBound, partitionIndex - 1);
                Sort(arrayToSort, partitionIndex + 1, upperBound);
            }
            else
            {
                // Reuse existing HeapSort
                HeapSort.Sort(arrayToSort, lowerBound, upperBound);
            }
        }

        private static int Partition(int[] arrayToSort, int lowerBound, int upperBound)
        {
            int pivotElement = arrayToSort[upperBound];
            int smallerElementIndex = lowerBound;

            for (int j = lowerBound; j < upperBound; j++)
            {
                if (arrayToSort[j] < pivotElement)
                {
                    int temp = arrayToSort[smallerElementIndex];
                    arrayToSort[smallerElementIndex] = arrayToSort[j];
                    arrayToSort[j] = temp;
                    smallerElementIndex++;
                }
            }

            int swapTemp = arrayToSort[smallerElementIndex];
            arrayToSort[smallerElementIndex] = arrayToSort[upperBound];
            arrayToSort[upperBound] = swapTemp;

            return smallerElementIndex;
        }
    }
}
