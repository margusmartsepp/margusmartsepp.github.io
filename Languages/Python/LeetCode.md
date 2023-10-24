## LeetCode - C#
### 1. Two Sum
Easy
```python
class Solution(object):
    def twoSum(self, numbers, target_sum):
        """
        Find indices of two numbers that sum up to the target sum.

        Args:
        numbers (List[int]): List of integers.
        target_sum (int): Target sum.

        Returns:
        List[int]: Indices of two numbers that sum up to target_sum.
        """
        num_to_index = {}

        for index, number in enumerate(numbers):
            required_complement = target_sum - number

            if required_complement in num_to_index:
                return [num_to_index[required_complement], index]

            num_to_index[number] = index
```
| Metric       | Complexity | Performance                | Benchmark                |
|--------------|------------|----------------------------|--------------------------|
| **Runtime**  | \(O(n)\)   | 38ms                       | Beats 77.81% of Python users |
| **Memory**   | \(O(n)\)   | 14.06MB                    | Beats 75.20% of Python users |

### 2. Add Two Numbers
Medium
```python
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution(object):
    def addTwoNumbers(self, l1, l2):
        """
        Add two numbers represented by linked lists.

        Args:
        l1 (ListNode): First linked list
        l2 (ListNode): Second linked list

        Returns:
        ListNode: Sum as a linked list
        """
        # Initialize current node to dummy head of the returning list.
        dummy_head = ListNode(0)
        current_node = dummy_head
        carry = 0
        
        # Loop through lists l1 and l2 until you reach both ends.
        while l1 or l2:
            # At the start of each iteration, we should add carry from last iteration.
            total_sum = carry
            
            # Add l1 and l2 values to the sum if they are present.
            if l1:
                total_sum += l1.val
                l1 = l1.next
            if l2:
                total_sum += l2.val
                l2 = l2.next
            
            # Update carry for next calculation
            carry = total_sum // 10
            
            # Update the result list.
            current_node.next = ListNode(total_sum % 10)
            current_node = current_node.next
        
        # In case the final sum has a carry, create an extra node.
        if carry > 0:
            current_node.next = ListNode(carry)
        
        return dummy_head.next
```
| Metric       | Complexity     | Performance                | Benchmark                   |
|--------------|----------------|----------------------------|-----------------------------|
| **Runtime**  | \(O(max(m,n))\)| 39ms                       | Beats 82.2% of Python users  |
| **Memory**   | \(O(max(m,n))\)| 13.4MB                     | Beats 14.98% of Python users |
### 3. Longest Substring Without Repeating Characters
Medium
```python
class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        Find the length of the longest substring without repeating characters.
        
        Args:
            s (str): Input string
        
        Returns:
            int: Length of the longest substring without repeating characters
        """
        start_index = 0
        max_length = 0
        char_index_map = {}

        for end_index, char in enumerate(s):
            if char in char_index_map and char_index_map[char] >= start_index:
                start_index = char_index_map[char] + 1
            char_index_map[char] = end_index
            max_length = max(max_length, end_index - start_index + 1)

        return max_length
```
| Metric       | Complexity | Performance   | Benchmark                    |
|--------------|------------|---------------|------------------------------|
| **Runtime**  | \(O(n)\)   | 25ms          | Beats 93.44% of Python users |
| **Memory**   | \(O(k)\)   | 13.45MB       | Beats 77.81% of Python users |
### 4. Median of Two Sorted Arrays
Hard
```python
class Solution(object):
    def findMedianSortedArrays(self, nums1, nums2):
        """
        Find the median of two sorted arrays.

        Args:
        nums1 (List[int]): First sorted array.
        nums2 (List[int]): Second sorted array.

        Returns:
        float: The median of the two sorted arrays.
        """
        merged_length = len(nums1) + len(nums2)
        is_odd = merged_length % 2 == 1
        median_idx = merged_length // 2
        
        i, j, k = 0, 0, 0
        median_elements = [0, 0]
        
        while i + j <= median_idx:
            last_element = 0
            if i < len(nums1) and (j >= len(nums2) or nums1[i] < nums2[j]):
                last_element = nums1[i]
                i += 1
            else:
                last_element = nums2[j]
                j += 1
            
            if is_odd and i + j == median_idx + 1:
                return float(last_element)
            
            if not is_odd:
                if i + j == median_idx:
                    median_elements[0] = last_element
                elif i + j == median_idx + 1:
                    median_elements[1] = last_element
                    return sum(median_elements) / 2.0
```
| Metric       | Complexity            | Performance   | Benchmark                   |
|--------------|-----------------------|---------------|-----------------------------|
| **Runtime**  | \(O(log(m + n))\)    | 58ms          | Beats 82.67% of Python users |
| **Memory**   | \(O(1)\)              | 13.38MB       | Beats 76.01% of Python users |
