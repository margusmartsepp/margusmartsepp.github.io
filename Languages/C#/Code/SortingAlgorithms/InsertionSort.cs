using System;

namespace SortingAlgorithms
{
    public static class InsertionSort
    {
        public static void Sort(int[] arrayToSort)
        {
            for (int currentIndex = 1; currentIndex < arrayToSort.Length; currentIndex++)
            {
                int currentElement = arrayToSort[currentIndex];
                int previousIndex = currentIndex - 1;

                // Shift elements that are greater than the current element to one position ahead
                while (previousIndex >= 0 && arrayToSort[previousIndex] > currentElement)
                {
                    arrayToSort[previousIndex + 1] = arrayToSort[previousIndex];
                    previousIndex--;
                }
                arrayToSort[previousIndex + 1] = currentElement;
            }
        }
    }
}
