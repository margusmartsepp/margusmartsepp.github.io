# [Sorting Algorithms](#Sorting-Algorithms)
TODO: Include benchmark tests and their results to analyze the performance of the algorithm.
TODO: Consider implementing both iterative and recursive variants of the algorithm to compare their efficiency.
TODO: Different data structures have varying performance characteristics for operations such as adding, inserting, deleting, maintaining, and lookup. It's important to consider these differences when choosing the appropriate data structure for your algorithm.
TODO: Keep in mind that an algorithm may be efficient for one data structure but not necessarily for all. So, it's crucial to consider the specific requirements and constraints of your problem.
TODO: Consider utilizing generics, which allow for the creation of reusable algorithms that can work with different data types. This can enhance the flexibility and versatility of your code.

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

**How It Works**

1. **Select a Pivot**: Choose a 'pivot' element from the array. The choice of pivot selection and partitioning schemes greatly affects the algorithm's performance.
2. **Partition**: Reorder the array so that all elements with values less than the pivot come before the pivot, while all elements with values greater than the pivot come after it. The pivot is in its final sorted position after this step.
3. **Recursively Sort Sub-arrays**: Apply the above steps recursively to the two sub-arrays.
4. **Base Case**: The base case of the recursion is an array of size zero or one, which is already sorted.

| Code | Tests |
|------|-------|
| [QuickSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/QuickSort.cs) | [QuickSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/QuickSortTests.cs) |

### [Merge Sort](#Merge-Sort)

**How It Works**

1. **Divide**: Continuously divide the unsorted list into `n` sub-lists, each containing one element, until each sub-list contains only one element.
2. **Conquer**: Repeatedly merge sub-lists to produce new sorted sub-lists until there is only one sub-list remaining.

| Code | Tests |
|------|-------|
| [MergeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/MergeSort.cs) | [MergeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/MergeSortTests.cs) |

### [Heap Sort](#Heap-Sort)

**How It Works**

1. **Build Heap**: Transform the array into a binary max-heap.
2. **Extract Max**: Repeatedly remove the maximum element from the heap and insert it at the end of the array.
3. **Heapify**: After each extraction, heapify the reduced heap.
4. **Repeat**: Continue the process until the heap is empty.

| Code | Tests |
|------|-------|
| [HeapSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/HeapSort.cs) | [HeapSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/HeapSortTests.cs) |

### [Tim Sort](#Tim-Sort)

**How It Works**

1. **Divide and Sort**: Divide the array into small chunks, known as "runs," and sort them using Insertion Sort.
2. **Merge**: Merge the sorted runs using a modified Merge Sort algorithm, taking advantage of the sorted runs to optimize the process.

| Code | Tests |
|------|-------|
| [TimSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/TimSort.cs) | [TimSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/TimSortTests.cs) |

### [Shell Sort](#Shell-Sort)

**How It Works**

1. **Gap Sequence**: Start with a large gap and reduce the gap by a shrink factor, usually by half.
2. **Compare and Swap**: Compare elements that are `gap` distance apart and swap them if necessary.
3. **Reduce Gap**: Reduce the gap and repeat the process until the gap is 1.

| Code | Tests |
|------|-------|
| [ShellSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/ShellSort.cs) | [ShellSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/ShellSortTests.cs) |
                                                 
## [Hybrid-Sorts](#Hybrid-Sorts)
### [Intro Sort](#Intro-Sort)

**How It Works**

1. **Choose Sorting Algorithm**: Intro Sort begins with Quick Sort and switches to Heap Sort when the recursion depth exceeds a level based on the number of elements being sorted.
2. **Quick Sort Phase**: Similar to Quick Sort, it partitions the array and recursively sorts the partitions.
3. **Heap Sort Phase**: If the recursion depth exceeds a certain limit, switch to Heap Sort to avoid Quick Sort's worst-case time complexity.

| Code | Tests |
|------|-------|
| [IntroSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/IntroSort.cs) | [IntroSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/IntroSortTests.cs) |

### [Block Sort](#Block-Sort)

**How It Works**

1. **Partition**: Divide the array into smaller blocks of a fixed size.
2. **Sort Blocks**: Sort each block using an efficient sorting algorithm like Quick Sort or Merge Sort.
3. **Merge**: Merge the sorted blocks to produce a fully sorted array.

| Code | Tests |
|------|-------|
| [BlockSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/BlockSort.cs) | [BlockSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/BlockSortTests.cs) |

## [Non-Comparison Sorts](#Non-Comparison-Sorts)
### [Radix Sort](#Radix-Sort)

**How It Works**

1. **Find the Maximum Number**: To know the number of digits.
2. **Digit by Digit Sort**: Do counting sort for every digit. Note that instead of passing digit number, the actual place value is passed.

| Code | Tests |
|------|-------|
| [RadixSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/RadixSort.cs) | [RadixSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/RadixSortTests.cs) |

### [Counting Sort](#Counting-Sort)

**How It Works**

1. **Find Range**: Determine the range of input values to know the size of the counting array.
2. **Initialize Count Array**: Create an array of zeros with a length equal to the range.
3. **Count Occurrences**: Traverse the input array and increment the corresponding index in the count array.
4. **Calculate Cumulative Count**: Update the count array such that each element stores the sum of the previous counts.
5. **Place Elements**: Use the count array to place the elements in the output array in sorted order.

| Code | Tests |
|------|-------|
| [CountingSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/CountingSort.cs) | [CountingSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/CountingSortTests.cs) |

### [Bucket Sort](#Bucket-Sort)

**How It Works**

1. **Initialize Buckets**: Create an empty array of buckets, each capable of holding a range of values.
2. **Distribute Elements**: Traverse the original array, placing each element into a bucket based on its value.
3. **Sort Buckets**: Sort each non-empty bucket individually.
4. **Concatenate Buckets**: Traverse the array of buckets, appending the elements of each bucket to a new array.

| Code | Tests |
|------|-------|
| [BucketSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/BucketSort.cs) | [BucketSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/BucketSortTests.cs) |

## [Elementary Sorts](#Elementary-Sorts)
### [Bubble Sort](#Bubble-Sort)

**How It Works**

1. **Iterate**: Traverse through the list, comparing adjacent elements.
2. **Swap**: If the adjacent elements are in the wrong order, swap them.
3. **Repeat**: Continue the process for each element, ignoring the last sorted element in each iteration.
4. **Terminate**: The algorithm terminates when no more swaps are needed, indicating that the list is sorted.

| Code | Tests |
|------|-------|
| [BubbleSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/BubbleSort.cs) | [BubbleSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/BubbleSortTests.cs) |

### [Insertion Sort](#Insertion-Sort)

**How It Works**

1. **Iterate**: Traverse from the second element to the last element in the array.
2. **Compare and Insert**: For each element, compare it with the elements before it and insert it into its correct position by swapping.
3. **Repeat**: Continue the process for each of the elements in the array.

| Code | Tests |
|------|-------|
| [InsertionSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/InsertionSort.cs) | [InsertionSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/InsertionSortTests.cs) |

### [Selection Sort](#Selection-Sort)

**How It Works**

1. **Find Minimum Element**: Traverse the array to find the minimum element.
2. **Swap**: Swap the minimum element found with the first element of the array.
3. **Iterate**: Move the boundary of the unsorted array one element ahead and repeat steps 1 and 2 until the array is sorted.

| Code | Tests |
|------|-------|
| [SelectionSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/SelectionSort.cs) | [SelectionSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/SelectionSortTests.cs) |

### [Cocktail Sort](#Cocktail-Sort)

**How It Works**

1. **Bi-Directional Traversal**: Unlike Bubble Sort, which only traverses the list in one direction, Cocktail Sort traverses the list in both directions.
2. **Forward Pass**: Compare adjacent elements and swap them if they are in the wrong order, moving from the beginning to the end of the list.
3. **Backward Pass**: Similar to the forward pass, but moves from the end to the beginning of the list.
4. **Repeat**: Continue the process of forward and backward passes until the list is sorted.

| Code | Tests |
|------|-------|
| [CocktailSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/CocktailSort.cs) | [CocktailSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/CocktailSortTests.cs) |

### [Odd-Even Sort](#Odd-Even-Sort)

**How It Works**

1. **Odd-Even Phase**: Compare all odd-indexed elements with their next adjacent elements and swap them if they are out of order.
2. **Even-Odd Phase**: Compare all even-indexed elements with their next adjacent elements and swap them if they are out of order.
3. **Repeat**: Continue alternating between the odd-even and even-odd phases until the array is sorted.

| Code | Tests |
|------|-------|
| [OddEvenSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/OddEvenSort.cs) | [OddEvenSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/OddEvenSortTests.cs) |
   
### [Gnome Sort](#Gnome-Sort)

**How It Works**

1. **Initialize**: Start at the first element as the current element.
2. **Compare and Swap**: Compare the current element with the next element. If the current element is greater than the next element, they are swapped.
3. **Advance or Retreat**: If the swap was made or you're at the start of the array, move one position forward. Otherwise, move one position backward.
4. **Iterate**: Repeat steps 2-3 until the array is sorted.

| Code | Tests |
|------|-------|
| [GnomeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/GnomeSort.cs) | [GnomeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/GnomeSortTests.cs) |

### [Comb Sort](#Comb-Sort)

**How It Works**

1. **Initialize Gap**: Start with a large gap and reduce it by a shrink factor (commonly 1.3).
2. **Compare and Swap**: Compare elements that are `gap` distance apart and swap them if they are in the wrong order.
3. **Reduce Gap**: Reduce the gap and repeat the process until the gap becomes 1.
4. **Final Pass**: Perform a final pass with a gap of 1 to ensure the array is fully sorted.

| Code | Tests |
|------|-------|
| [CombSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/CombSort.cs) | [CombSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/CombSortTests.cs) |

### [Pancake Sort](#Pancake-Sort)

**How It Works**

1. **Find Max**: Locate the maximum element in the array.
2. **Flip**: Use a spatula (figuratively speaking) to flip the array from the start to the maximum element, bringing the maximum element to the front.
3. **Flip Again**: Flip the array from the start to the current length of the unsorted partition to move the maximum element to its correct position.
4. **Repeat**: Reduce the length of the unsorted partition by one and go back to the first step, until the array is sorted.

| Code | Tests |
|------|-------|
| [PancakeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/PancakeSort.cs) | [PancakeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/PancakeSortTests.cs) |

### [Stooge Sort](#Stooge-Sort)

**How It Works**

1. **Divide**: Divide the array into three parts.
2. **Recursively Sort**: Recursively sort the first two-thirds, then the last two-thirds, and finally the first two-thirds again.
3. **Conquer**: If the value at the start is greater than the value at the end, swap them.

| Code | Tests |
|------|-------|
| [StoogeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/StoogeSort.cs) | [StoogeSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/StoogeSortTests.cs) |

### [Bead Sort](#Bead-Sort)

**How It Works**

1. **Initialization**: Create a set of bins, each representing a digit in the numbers to be sorted.
2. **Drop Beads**: For each number, drop a bead in each bin corresponding to the value of that digit.
3. **Count Beads**: Count the number of beads in each bin, from top to bottom, to obtain the sorted numbers.

| Code | Tests |
|------|-------|
| [BeadSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Code/SortingAlgorithms/BeadSort.cs) | [BeadSort](https://github.com/margusmartsepp/margusmartsepp.github.io/blob/master/Languages/C%23/Tests/SortingAlgorithms.Tests/BeadSortTests.cs) |
