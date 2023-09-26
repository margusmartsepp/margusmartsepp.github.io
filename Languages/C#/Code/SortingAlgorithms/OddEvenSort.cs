using System;

namespace SortingAlgorithms
{
    public static class OddEvenSort
    {
        public static void Sort(int[] arrayToSort)
        {
            bool isSorted = false;

            while (!isSorted)
            {
                isSorted = true;

                // Odd-Even Phase
                for (int i = 1; i <= arrayToSort.Length - 2; i += 2)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        Swap(arrayToSort, i, i + 1);
                        isSorted = false;
                    }
                }

                // Even-Odd Phase
                for (int i = 0; i <= arrayToSort.Length - 2; i += 2)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        Swap(arrayToSort, i, i + 1);
                        isSorted = false;
                    }
                }
            }
        }

        private static void Swap(int[] arrayToSort, int index1, int index2)
        {
            int temp = arrayToSort[index1];
            arrayToSort[index1] = arrayToSort[index2];
            arrayToSort[index2] = temp;
        }
    }
}
