using System;

namespace SortingAlgorithms
{
    public static class BubbleSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int arrayLength = arrayToSort.Length;
            bool elementsSwapped;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                elementsSwapped = false;

                for (int j = 0; j < arrayLength - i - 1; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        // Swap arrayToSort[j] and arrayToSort[j + 1]
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;

                        elementsSwapped = true;
                    }
                }

                // If no elements were swapped in the inner loop, the array is sorted
                if (!elementsSwapped)
                {
                    break;
                }
            }
        }
    }
}
