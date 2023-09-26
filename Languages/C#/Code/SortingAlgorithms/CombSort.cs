using System;

namespace SortingAlgorithms
{
    public static class CombSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int arrayLength = arrayToSort.Length;

            // Initialize gap and shrink factor
            int gap = arrayLength;
            float shrinkFactor = 1.3f;
            bool isSorted = false;

            while (!isSorted)
            {
                // Update gap for the next iteration
                gap = (int)(gap / shrinkFactor);
                if (gap <= 1)
                {
                    gap = 1;
                    isSorted = true;
                }

                // Compare and swap elements separated by gap
                for (int i = 0; i < arrayLength - gap; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + gap])
                    {
                        int temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + gap];
                        arrayToSort[i + gap] = temp;

                        isSorted = false;
                    }
                }
            }
        }
    }
}
