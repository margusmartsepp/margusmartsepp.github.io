using System;

namespace SearchingAlgorithms
{
    public static class FibonacciSearch
    {
        public static int Search(int[] arrayToSearch, int targetElement)
        {
            int fib1 = 0;
            int fib2 = 1;
            int fib = fib1 + fib2;

            while (fib < arrayToSearch.Length)
            {
                fib1 = fib2;
                fib2 = fib;
                fib = fib1 + fib2;
            }

            int offsetIndex = -1;

            while (fib > 1)
            {
                int partitionIndex = Math.Min(offsetIndex + fib1, arrayToSearch.Length - 1);

                if (arrayToSearch[partitionIndex] < targetElement)
                {
                    fib = fib2;
                    fib2 = fib1;
                    fib1 = fib - fib2;
                    offsetIndex = partitionIndex;
                }
                else if (arrayToSearch[partitionIndex] > targetElement)
                {
                    fib = fib1;
                    fib2 = fib2 - fib1;
                    fib1 = fib - fib2;
                }
                else
                {
                    return partitionIndex;
                }
            }

            if (fib1 == 1 && arrayToSearch[offsetIndex + 1] == targetElement)
            {
                return offsetIndex + 1;
            }

            return -1;
        }
    }
}
