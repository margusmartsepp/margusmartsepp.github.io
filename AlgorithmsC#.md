# [Sorting Algorithms](#Sorting-Algorithms)

| [Category](#Category)   | Algorithm (Link to .md) | Time Complexity (Worst, Average, Best) | Memory Complexity | Performance Metrics |
|-------------------------|--------------------------|----------------------------------------|-------------------|---------------------|
| [Efficient Sorts](#Efficient-Sorts) | [Quick Sort](#Quick-Sort) | O(n^2), O(n log n), O(n log n) | O(log n) | Average-Case Time Complexity, Data Sensitivity (Varies) |
| [Efficient Sorts](#Efficient-Sorts) | [Merge Sort](#Merge-Sort) | O(n log n), O(n log n), O(n log n) | O(n) | Average-Case Time Complexity |
| [Efficient Sorts](#Efficient-Sorts) | [Heap Sort](#Heap-Sort) | O(n log n), O(n log n), O(n log n) | O(1) | Worst-Case Time Complexity |
| [Efficient Sorts](#Efficient-Sorts) | [Tim Sort](#Tim-Sort) | O(n log n), O(n log n), O(n log n) | O(n) | Average-Case Time Complexity |
| [Efficient Sorts](#Efficient-Sorts) | [Shell Sort](#Shell-Sort) | O(n^2), O(n log^2 n), O(n log n) | O(1) | Worst-Case Time Complexity |
| [Hybrid Sorts](#Hybrid-Sorts) | [Intro Sort](#Intro-Sort) | O(n log n), O(n log n), O(n log n) | O(log n) | Average-Case Time Complexity |
| [Hybrid Sorts](#Hybrid-Sorts) | [Block Sort](#Block-Sort) | O(n log n), O(n log n), O(n log n) | O(n) | Average-Case Time Complexity |
| [Non-Comparison Sorts](#Non-Comparison-Sorts) | [Radix Sort](#Radix-Sort) | O(nk), O(nk), O(nk) | O(n+k) | Average-Case Time Complexity |
| [Non-Comparison Sorts](#Non-Comparison-Sorts) | [Counting Sort](#Counting-Sort) | O(n+k), O(n+k), O(n+k) | O(k) | Average-Case Time Complexity |
| [Non-Comparison Sorts](#Non-Comparison-Sorts) | [Bucket Sort](#Bucket-Sort) | O(n^2), O(n+k), O(n+k) | O(n) | Worst-Case Time Complexity, Data Sensitivity (Varies) |
| [Elementary Sorts](#Elementary-Sorts) | [Bubble Sort](#Bubble-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity, Data Sensitivity (Stable) |
| [Elementary Sorts](#Elementary-Sorts) | [Insertion Sort](#Insertion-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity, Data Sensitivity (Stable) |
| [Elementary Sorts](#Elementary-Sorts) | [Selection Sort](#Selection-Sort) | O(n^2), O(n^2), O(n^2) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Cocktail Sort](#Cocktail-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Odd-Even Sort](#Odd-Even-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Gnome Sort](#Gnome-Sort) | O(n^2), O(n^2), O(n) | O(1) | Worst-Case Time Complexity |
| [Elementary Sorts](#Elementary-Sorts) | [Comb Sort](#Comb-Sort) | O(n^2), O(n^2/log n), O(n) | O(1) | Worst-Case Time Complexity |
| [Special-Purpose Sorts](#Special-Purpose-Sorts) | [Pancake Sort](#Pancake-Sort) | O(n), O(n), O(n) | O(1) | Worst-Case Time Complexity |
| [Special-Purpose Sorts](#Special-Purpose-Sorts) | [Stooge Sort](#Stooge-Sort) | O(n^(log 3/log 1.5)), O(n^(log 3/log 1.5)), O(n^(log 3/log 1.5)) | O(1) | Worst-Case Time Complexity |
| [Special-Purpose Sorts](#Special-Purpose-Sorts) | [Bead Sort](#Bead-Sort) | O(n), O(n), O(n) | O(n) | Worst-Case Time Complexity |

---
## [Efficient-Sorts](#Quick-Sort)
### [Quick Sort](#Quick-Sort)

#### How It Works

1. **Select a Pivot**: Choose a 'pivot' element from the array. The choice of pivot selection and partitioning schemes greatly affects the algorithm's performance.
2. **Partition**: Reorder the array so that all elements with values less than the pivot come before the pivot, while all elements with values greater than the pivot come after it. The pivot is in its final sorted position after this step.
3. **Recursively Sort Sub-arrays**: Apply the above steps recursively to the two sub-arrays.
4. **Base Case**: The base case of the recursion is an array of size zero or one, which is already sorted.

#### C# Code Implementation

Call it like this:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
QuickSort.Sort(arr, 0, arr.Length - 1);
```

Code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort the elements before and after partition
                Sort(arr, low, pivotIndex);
                Sort(arr, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            // Choose the rightmost element as the pivot
            int pivot = arr[high];
            int i = low;

            // Partition the array into two parts using the pivot
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                }
            }

            // Swap arr[i] and arr[high] (or pivot)
            int temp1 = arr[i];
            arr[i] = arr[high];
            arr[high] = temp1;

            return i;
        }
    }
}
```
### [Merge Sort](#Merge-Sort)

#### How It Works

1. **Divide**: Continuously divide the unsorted list into `n` sub-lists, each containing one element, until each sub-list contains only one element.
2. **Conquer**: Repeatedly merge sub-lists to produce new sorted sub-lists until there is only one sub-list remaining.

#### C# Code Implementation

Here's how you can call the Merge Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
MergeSort.Sort(arr, 0, arr.Length - 1);
```

code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class MergeSort
    {
        public static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                // Recursively sort the first and second halves
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);

                // Merge the sorted halves
                Merge(arr, left, middle, right);
            }
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, middle + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
```
### [Heap Sort](#Heap-Sort)

#### How It Works

1. **Build Heap**: Transform the array into a binary max-heap.
2. **Extract Max**: Repeatedly remove the maximum element from the heap and insert it at the end of the array.
3. **Heapify**: After each extraction, heapify the reduced heap.
4. **Repeat**: Continue the process until the heap is empty.

#### C# Code Implementation

Here's how you can call the Heap Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
HeapSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class HeapSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            // Build heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }

            // Extract elements from heap one by one
            for (int i = n - 1; i >= 0; i--)
            {
                // Move current root to end
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Heapify the reduced heap
                Heapify(arr, i, 0);
            }
        }

        private static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }

            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

                // Heapify the affected sub-tree
                Heapify(arr, n, largest);
            }
        }
    }
}
```
### [Tim Sort](#Tim-Sort)

#### How It Works

1. **Divide and Sort**: Divide the array into small chunks, known as "runs," and sort them using Insertion Sort.
2. **Merge**: Merge the sorted runs using a modified Merge Sort algorithm, taking advantage of the sorted runs to optimize the process.

#### C# Code Implementation

Here's how you can call the Tim Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
TimSort.Sort(arr, arr.Length);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class TimSort
    {
        private const int RUN = 32;

        public static void Sort(int[] arr, int n)
        {
            for (int i = 0; i < n; i += RUN)
            {
                InsertionSort(arr, i, Math.Min((i + RUN - 1), (n - 1)));
            }

            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size - 1), (n - 1));

                    Merge(arr, left, mid, right);
                }
            }
        }

        private static void InsertionSort(int[] arr, int left, int right)
        {
            for (int i = left + 1; i <= right; i++)
            {
                int j = i;
                while (j > left && arr[j] < arr[j - 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j--;
                }
            }
        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int len1 = m - l + 1, len2 = r - m;
            int[] left = new int[len1];
            int[] right = new int[len2];
            Array.Copy(arr, l, left, 0, len1);
            Array.Copy(arr, m + 1, right, 0, len2);

            int i = 0;
            int j = 0;
            int k = l;

            while (i < len1 && j < len2)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < len1)
            {
                arr[k] = left[i];
                k++;
                i++;
            }

            while (j < len2)
            {
                arr[k] = right[j];
                k++;
                j++;
            }
        }
    }
}
```
### [Shell Sort](#Shell-Sort)

#### How It Works

1. **Gap Sequence**: Start with a large gap and reduce the gap by a shrink factor, usually by half.
2. **Compare and Swap**: Compare elements that are `gap` distance apart and swap them if necessary.
3. **Reduce Gap**: Reduce the gap and repeat the process until the gap is 1.

#### C# Code Implementation

Here's how you can call the Shell Sort function:

```csharp
int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
ShellSort.Sort(arr);
```
code:
```csharp
using System;

namespace SortingAlgorithms
{
    public static class ShellSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int gap = n / 2;

            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    int j;

                    for (j = i; j >= gap && arr[j - gap] > temp; j -= gap)
                    {
                        arr[j] = arr[j - gap];
                    }

                    arr[j] = temp;
                }

                gap /= 2;
            }
        }
    }
}                                                    
```
---


## Fast Inverse Squere Root aka Quake  III Algorithm
Following has some minor improvements over the original ( see [youtube](https://www.youtube.com/watch?v=p8u_k2LIZyo), see [stackoverflow](https://stackoverflow.com/questions/268853/is-it-possible-to-write-quakes-fast-invsqrt-function-in-c) ). Original was using an inferior constant value ```0x5f3759df``` ( see [paper](http://www.lomont.org/papers/2003/InvSqrt.pdf) ) and unsafe pointer casts. Furthermore, the readability of the document has been improved by separating functionality into three methods. By default, compile-time optimizations would inline method calls in Release config, but optional implementation attribute ```AggressiveInlining``` ensures that we will not lose performance.
```c#
using static System.BitConverter;
using System.Runtime.CompilerServices;

public float InvSqrt(float x) => NewtonMethod(InvSqrtFast(x), 0.5f * x);
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private float InvSqrtFast(float x) => Int32BitsToSingle(0x5f375a86 - (SingleToInt32Bits(x) >> 1));
[MethodImpl(MethodImplOptions.AggressiveInlining)]
private float NewtonMethod(float x, float half) => x * (1.5f - half * x * x);
```