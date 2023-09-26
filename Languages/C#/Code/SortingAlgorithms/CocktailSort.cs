using System;

namespace SortingAlgorithms
{
    public static class CocktailSort
    {
        public static void Sort(int[] arrayToSort)
        {
            bool isSwapped = true;
            int startIndex = 0;
            int endIndex = arrayToSort.Length;

            while (isSwapped)
            {
                isSwapped = false;

                // Forward pass
                for (int i = startIndex; i < endIndex - 1; ++i)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        int temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                if (!isSwapped)
                    break;

                isSwapped = false;
                endIndex--;

                // Backward pass
                for (int i = endIndex - 1; i >= startIndex; i--)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        int temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[i + 1];
                        arrayToSort[i + 1] = temp;
                        isSwapped = true;
                    }
                }

                startIndex++;
            }
        }
    }
}
