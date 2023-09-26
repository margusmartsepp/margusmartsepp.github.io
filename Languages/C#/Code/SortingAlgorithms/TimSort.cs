using System;

namespace SortingAlgorithms
{
    public static class TimSort
    {
        private const int RunLength = 32;

        public static void Sort(int[] arrayToSort, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i += RunLength)
            {
                InsertionSort(arrayToSort, i, Math.Min((i + RunLength - 1), (arrayLength - 1)));
            }

            for (int segmentSize = RunLength; segmentSize < arrayLength; segmentSize = 2 * segmentSize)
            {
                for (int leftIndex = 0; leftIndex < arrayLength; leftIndex += 2 * segmentSize)
                {
                    int middleIndex = leftIndex + segmentSize - 1;
                    int rightIndex = Math.Min((leftIndex + 2 * segmentSize - 1), (arrayLength - 1));

                    Merge(arrayToSort, leftIndex, middleIndex, rightIndex);
                }
            }
        }

        private static void InsertionSort(int[] arrayToSort, int leftIndex, int rightIndex)
        {
            for (int i = leftIndex + 1; i <= rightIndex; i++)
            {
                int j = i;
                while (j > leftIndex && arrayToSort[j] < arrayToSort[j - 1])
                {
                    int temp = arrayToSort[j];
                    arrayToSort[j] = arrayToSort[j - 1];
                    arrayToSort[j - 1] = temp;
                    j--;
                }
            }
        }

        private static void Merge(int[] arrayToSort, int leftIndex, int middleIndex, int rightIndex)
        {
            int leftSegmentLength = middleIndex - leftIndex + 1, rightSegmentLength = rightIndex - middleIndex;
            int[] leftSegment = new int[leftSegmentLength];
            int[] rightSegment = new int[rightSegmentLength];
            Array.Copy(arrayToSort, leftIndex, leftSegment, 0, leftSegmentLength);
            Array.Copy(arrayToSort, middleIndex + 1, rightSegment, 0, rightSegmentLength);

            int i = 0, j = 0, k = leftIndex;

            while (i < leftSegmentLength && j < rightSegmentLength)
            {
                if (leftSegment[i] <= rightSegment[j])
                {
                    arrayToSort[k] = leftSegment[i];
                    i++;
                }
                else
                {
                    arrayToSort[k] = rightSegment[j];
                    j++;
                }
                k++;
            }

            while (i < leftSegmentLength)
            {
                arrayToSort[k] = leftSegment[i];
                k++;
                i++;
            }

            while (j < rightSegmentLength)
            {
                arrayToSort[k] = rightSegment[j];
                k++;
                j++;
            }
        }
    }
}
