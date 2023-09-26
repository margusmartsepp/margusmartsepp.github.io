using System;

namespace SortingAlgorithms
{
    public static class PancakeSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int arraySize = arrayToSort.Length;

            for (int currentSize = arraySize; currentSize > 1; --currentSize)
            {
                int maxElementIndex = FindMaxElementIndex(arrayToSort, currentSize);

                if (maxElementIndex != currentSize - 1)
                {
                    FlipSubarray(arrayToSort, maxElementIndex);
                    FlipSubarray(arrayToSort, currentSize - 1);
                }
            }
        }

        private static int FindMaxElementIndex(int[] arrayToSort, int subarraySize)
        {
            int maxIndex = 0;
            for (int i = 1; i < subarraySize; ++i)
            {
                if (arrayToSort[i] > arrayToSort[maxIndex])
                    maxIndex = i;
            }
            return maxIndex;
        }

        private static void FlipSubarray(int[] arrayToSort, int endIndex)
        {
            int startIndex = 0;
            while (startIndex < endIndex)
            {
                int temp = arrayToSort[startIndex];
                arrayToSort[startIndex] = arrayToSort[endIndex];
                arrayToSort[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
        }
    }
}
