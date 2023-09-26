using System;

namespace SortingAlgorithms
{
    public static class GnomeSort
    {
        public static void Sort(int[] arrayToSort)
        {
            int currentIndex = 0;
            int arrayLength = arrayToSort.Length;

            while (currentIndex < arrayLength)
            {
                if (currentIndex == 0)
                    currentIndex++;
                if (arrayToSort[currentIndex] >= arrayToSort[currentIndex - 1])
                    currentIndex++;
                else
                {
                    int temp = arrayToSort[currentIndex];
                    arrayToSort[currentIndex] = arrayToSort[currentIndex - 1];
                    arrayToSort[currentIndex - 1] = temp;
                    currentIndex--;
                }
            }
        }
    }
}
