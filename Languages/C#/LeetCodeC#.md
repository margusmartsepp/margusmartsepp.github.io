## LeetCode - C#
### 1. Two Sum
Easy
```c#
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      var numsDictionary = new Dictionary<int, int>();

      for (int i = 0; i < nums.Length; i++)
      {
        if (numsDictionary.TryGetValue(target - nums[i], out int index))
        {          
          return new [] { index, i }; 
        }

        numsDictionary[nums[i]] = i;
      }

      return null;
    }
}
```
### 2. Add Two Numbers
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode c1 = l1;
        ListNode c2 = l2;
        ListNode sentinel = new ListNode(0);
        ListNode d = sentinel;
        int sum = 0;
        while (c1 != null || c2 != null) {
            sum /= 10;
            if (c1 != null) {
                sum += c1.val;
                c1 = c1.next;
            }
            if (c2 != null) {
                sum += c2.val;
                c2 = c2.next;
            }
            d.next = new ListNode(sum % 10);
            d = d.next;
        }
        if (sum / 10 == 1)
            d.next = new ListNode(1);
        return sentinel.next;
    }
}
```
### 3. Longest Substring Without Repeating Characters
Medium
```c#
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(String.IsNullOrEmpty(s))
            return 0;
        return s.Trim().Length <= 0 
            ? s.Distinct().Count()
            : Enumerable.Range(0, s.Length)
                .Select(o => {
                    var d = new HashSet<char>();
                    return s.Skip(o).TakeWhile(o => !d.Contains(o) && d.Add(o)).Count();
                }).Max();  
    }
}
```
### 4. Median of Two Sorted Arrays
Hard
```c#
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var myList = new List<int>(nums1);
        myList.AddRange(nums2);
        var arr = myList.OrderBy(o=>o).ToList();

        int n = arr.Count;    
        return (n % 2 == 0) 
			? ((double)(arr[n / 2] + arr[n / 2 - 1])) / 2
			: arr[n / 2];
    }
}
```
### 5. Longest Palindromic Substring
Medium
```c#
public class Solution {
    public string LongestPalindrome(string testingString) {
        int stringLength = testingString.Length;
        int maxPalindromeStringLength = 0;
        int maxPalindromeStringStartIndex = 0;

        for (int i = 0; i < stringLength; i++)
        {
            int currentCharIndex = i;

            for (int lastCharIndex = stringLength - 1; lastCharIndex > currentCharIndex; lastCharIndex--)
            {
                if (lastCharIndex - currentCharIndex + 1 < maxPalindromeStringLength)
                {
                    break;
                }

                bool isPalindrome = true;

                if (testingString[currentCharIndex] != testingString[lastCharIndex])
                {
                    continue;
                }
                else
                {
                    int matchedCharIndexFromEnd = lastCharIndex - 1;

                    for (int nextCharIndex = currentCharIndex + 1; nextCharIndex < matchedCharIndexFromEnd; nextCharIndex++)
                    {
                        if (testingString[nextCharIndex] != testingString[matchedCharIndexFromEnd])
                        {
                            isPalindrome = false;
                            break;
                        }
                        matchedCharIndexFromEnd--;
                    }
                }

                if (isPalindrome)
                {
                    if (lastCharIndex + 1 - currentCharIndex > maxPalindromeStringLength)
                    {
                        maxPalindromeStringStartIndex = currentCharIndex;
                        maxPalindromeStringLength = lastCharIndex + 1 - currentCharIndex;
                    }
                    break;
                }
            }
        }

        if(maxPalindromeStringLength>0)
        {
            return testingString.Substring(maxPalindromeStringStartIndex, maxPalindromeStringLength);
        }
        return ""+testingString.FirstOrDefault();
    }
}
```
### 6. ZigZag Conversion
Medium
```c#
public class Solution {
    public string Convert(string s, int numRows) {
        if(s.Length <= 1 || numRows == 1)
            return s;
        return new string(s.Select((o, i) => new { o, i=ZigZag(i, numRows) }).GroupBy(o=>o.i%numRows).SelectMany(o=>o).Select(o=>o.o).ToArray());
    }
    public static int ZigZag(int i, int num) 
    {
        var item = i % (num * 2 - 2);
        var result = item >= num ? Math.Abs(num * 2 - item -2) : item;
        return result;
    }
}
```
### 7. Reverse Integer
Easy
```c#
public class Solution {
    public int Reverse(int x) {
        var result = (x < 0) 
            ? -long.Parse(new string(Math.Abs((long)x).ToString().Reverse().ToArray()))
            : long.Parse(new string(x.ToString().Reverse().ToArray()));
        if(result > Int32.MaxValue || result < Int32.MinValue)
            return 0;
        return (int)result;
    }
}
```
### 8. String to Integer (atoi)
Medium
```c#
public class Solution {
    public int MyAtoi(string s)
    {
        var strValue = new string(s.Trim()
            .TakeWhile((o,i)=>char.IsDigit(o) || o=='-' && i == 0 || o == '+' && i == 0).ToArray());
        if (char.IsLetter(strValue.FirstOrDefault()) || string.IsNullOrEmpty(strValue))
            return 0;
        try
        {
            return int.Parse(strValue);
        }
        catch (System.OverflowException oex)
        {
            return strValue.First() == '-' ? int.MinValue : int.MaxValue;
        }
        catch (Exception ex)
        {
            return 0;
        }
    }
}
```
### 9. Palindrome Number
Easy
```c#
public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0)
            return false;
        return x.ToString() == new string(x.ToString().Reverse().ToArray());
    }
}
```
### 10. Regular Expression Matching
Hard
```c#
using System.Text.RegularExpressions;
public class Solution {
    public bool IsMatch(string text, string pattern) {
        Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
        Match m = r.Match(text);
        return m.Success && m.Groups.Cast<Match>().FirstOrDefault().Value == text;
    }
}
```
### 11. Container With Most Water
Medium
```c#
public class Solution {
    public int MaxArea(int[] height) {
        int l = 0;
        int r = height.Length - 1;
        int area = 0;
     
        while (l < r)
        {
            area = Math.Max(area, Math.Min(height[l], height[r]) * (r - l));                         
            if (height[l] < height[r])
                l += 1;                 
            else
                r -= 1;
        }
        return area;
    }
}
```
### 12. Integer to Roman
Medium
```c#
public class Solution {
    public static Dictionary<int, string> _map = new Dictionary<int, string>
          {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"}
          };
    public string IntToRoman(int num) {
          return _map.Aggregate(new string('I', num), (m, _) => m.Replace(new string('I', _.Key), _.Value));
    }
}
```
### 13. Roman to Integer
Easy
```c#
public class Solution {
    private static readonly Dictionary<char, int> RomanDictionary = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
    public int RomanToInt(string s) {
        var roman = s.ToUpper();
        int total = 0, minus = 0;

        for (int i = 0; i < roman.Length; i++) 
        {
            int thisNumeral = RomanDictionary[roman[i]] - minus;
            if (i >= roman.Length - 1 || thisNumeral + minus >= RomanDictionary[roman[i + 1]])
            {
                total += thisNumeral;
                minus = 0;
            }
            else
            {
                minus = thisNumeral;
            }
        }

        return total; 
    }
}
```
### 14. Longest Common Prefix
Easy
```c#
public class Solution {
    public string LongestCommonPrefix(string[] k) {
        if (k.Length == 0 || k.Any(o => o.Length == 0))
        {
            return "";
        }
        if (k.Length == 1)
        {
            return k.First();
        }
        var k1 = k.OrderBy(o => o.Length).FirstOrDefault();
        var result = k1.TakeWhile((o, i) => k.All(o => o[i] == k1[i]));
        return new string(result.ToArray());
    }
}
```
### 15. 3Sum
Medium
```c#
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        var num = nums.OrderBy(o => o).ToList();
        var res = new List<IList<int>>();
        for (int i = 0; i < num.Count - 2; i++)
        {
            if (i == 0 || (i > 0 && num[i] != num[i - 1]))
            {
                int lo = i + 1, hi = num.Count - 1, sum = 0 - num[i];
                while (lo < hi)
                {
                    if (num[lo] + num[hi] == sum)
                    {
                        res.Add(new int[] { num[i], num[lo], num[hi] }.ToList());
                        while (lo < hi && num[lo] == num[lo + 1])
                        {
                            lo++;
                        }

                        while (lo < hi && num[hi] == num[hi - 1])
                        {
                            hi--;
                        }

                        lo++;
                        hi--;
                    }
                    else if (num[lo] + num[hi] < sum)
                    {
                        lo++;
                    }
                    else
                    {
                        hi--;
                    }
                }
            }
        }
        return res;
    }
}
```
### 16. 3Sum Closest
Medium
```c#
public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        int diff = int.MaxValue, ret = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            int s = i + 1, e = nums.Length - 1;
            while (s < e)
            {
                int sum = nums[i] + nums[s] + nums[e];
                if (Math.Abs(target - sum) < diff)
                {
                    diff = Math.Abs(target - sum);
                    ret = sum;
                }
                if (sum < target) s++;
                else if (sum > target) e--;
                else return target;
            }
        }
        return ret;
    }
}
```
### 17. Letter Combinations of a Phone Number
Medium
```c#
public class Solution {
    public IList<string> LetterCombinations(string digits) 
    {
        var list = new List<string>();
        if (digits == null || digits.Length == 0) return list;
        list.Add("");
        var map = new string[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

        for (int i = 0; i < digits.Length; i++)
        {
            var nextList = new List<string>();
            int num = digits[i] - '0';
            foreach (string s in list)
            {
                for (int k = 0; k < map[num].Length; k++)
                {
                    nextList.Add(s + map[num][k]);
                }
            }
            list = nextList.ToList();
        }
        return list;
	}
}
```
### 18. 4Sum
Medium
```c#
public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        var result = new List<IList<int>>();
        if (nums == null || nums.Length < 4) return result;
        int low = 0, high = 0, sum = 0;
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j - i > 1 && nums[j - 1] == nums[j]) continue;
                low = j + 1; high = nums.Length - 1;
                while (low < high)
                {
                    sum = nums[i] + nums[j] + nums[low] + nums[high];
                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[i], nums[j], nums[low++], nums[high--] });
                        while (high > low && nums[high] == nums[high + 1]) high--;
                        while (low < high && nums[low] == nums[low - 1]) low++;
                    }
                    else if (sum > target)
                    {
                        --high;
                    }
                    else
                        ++low;
                }
            }
        }
        return result;
    }
}
```
### 19. Remove Nth Node From End of List
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if (head.next == null)
        {
            return null;
        }
        var count = 0;
        for (ListNode i = head; i != null; i = i.next, count++)
        {
        }
        var count2 = 0;
        var n2 = count - n - 1;
        if (n2 == -1) {
            return head.next;
        }
        for (ListNode i = head; i != null; i = i.next, count2++)
        {
            if (count2 == n2)
            {
                i.next = i.next.next;
            }
        }
        return head;
    }
}
```
### 20. Valid Parentheses
Easy
```c#
public class Solution {
    public bool IsValid(string s) {
        var stack = new Stack<char>();
        foreach (char c in s)
        {
            switch (c)
            {
                case '(': stack.Push(')'); break;
                case '{': stack.Push('}'); break;
                case '[': stack.Push(']'); break;
                default: if (!stack.Any() || stack.Pop() != c) return false; break;
            }
        }
        return !stack.Any();
    }
}
```
### 21. Merge Two Sorted Lists
Easy
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        var list = new List<ListNode>();
        var count = 0;
        for (ListNode i = l1; i != null; i = i.next)
        {
            list.Add(i);
        }
        for (ListNode i = l2; i != null; i = i.next)
        {
            list.Add(i);
        }
        if(list.Count==0)
        {
            return null;
        }
        var result = list.OrderBy(o=>o.val).ToList();
        for (int i = 0; i < result.Count-1; i++)
        {
            result[i].next = result[i + 1];
        }
        result[result.Count - 1].next = null;
        return result.FirstOrDefault();
    }
}
```
### 22. Generate Parentheses
Medium
```c#
public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var list = new List<string>();
        Backtrack(list, "", 0, 0, n);
        return list;
    }
    
    public void Backtrack(List<String> list, String str, int open, int close, int max)
    {        
        if(str.Length == max*2){
            list.Add(str);
            return;
        }        
        if(open < max)
            Backtrack(list, str+"(", open+1, close, max);
        if(close < open)
            Backtrack(list, str+")", open, close+1, max);
    }
}
```
### 23. Merge k Sorted Lists
Hard
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        var list = new List<ListNode>(lists.Length);
        if (lists.Length == 0)
        {
            return null;
        }  
        foreach (ListNode l in lists)
        {
            for (ListNode i = l; i != null; i = i.next)
            {
                list.Add(i);
            }
        }
        var result = list.OrderBy(o => o.val).ToList();
        if (result.Count == 0)
        {
            return null;
        }
        for (int i = 0; i < result.Count - 1; i++)
        {
            result[i].next = result[i + 1];
        }
        result[result.Count - 1].next = null;
        return result.FirstOrDefault();
    }
}
```
### 24. Swap Nodes in Pairs
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if ((head == null)||(head.next == null))
            return head;
        var n = head.next;
        head.next = SwapPairs(head.next.next);
        n.next = head;
        return n;
    }
}
```
### 25. Reverse Nodes in k-Group
Hard
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        var list = new List<ListNode>();
        var count = 0;
        for (ListNode i = head; i != null; i = i.next)
        {
            list.Add(i);
            count++;
        }
        var result = list.Select((o, i) => new { id = (count - (count % k)) > i ?  i + k - 2 * (i % k) : i + 1, o })
            .OrderBy(o => o.id).Select(o => o.o).ToArray();
        for (int i = 0; i < result.Length-1; i++)
        {
            result[i].next = result[i + 1];
        }
        result[result.Length - 1].next = null;
        return result.FirstOrDefault();
    }
}
```
### 26. Remove Duplicates from Sorted Array
Easy
```c#
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var result = nums.Distinct().ToArray();
        Buffer.BlockCopy(result, 0, nums, 0, result.Length * 4);
        Array.Clear(nums, result.Length, nums.Length - result.Length);
        return result.Length;
    }
}
```
### 27. Remove Element
Easy
```c#
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int begin=0;
        for(int i=0;i<nums.Length;i++) 
            if(nums[i]!=val) 
                nums[begin++]=nums[i];
        return begin;
    }
}
```
### 28. Implement strStr()
Easy
```c#
public class Solution {
    public int StrStr(string haystack, string needle) {
        for (int i = 0; ; i++)
        {
            for (int j = 0; ; j++)
            {
                if (j == needle.Length) return i;
                if (i + j == haystack.Length) return -1;
                if (needle[j] != haystack[i + j]) break;
            }
        }
    }
}
```
### 29. Divide Two Integers
Medium
```c#
public class Solution {
    public int Divide(int dividend, int divisor)
    {
        bool isNegative = (dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0) ? true : false;
        long absDividend = Math.Abs((long)dividend);
        long absDivisor = Math.Abs((long)divisor);
        long result = 0;
        while (absDividend >= absDivisor)
        {
            long tmp = absDivisor, count = 1;
            while (tmp <= absDividend)
            {
                tmp <<= 1;
                count <<= 1;
            }
            result += count >> 1;
            absDividend -= tmp >> 1;
        }
        return isNegative ? (int)~result + 1 : result > int.MaxValue ? int.MaxValue : (int)result;
    }
}
```
### 30. Substring with Concatenation of All Words
Hard
```c#
public class Solution {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var res = new List<int>();
            if (s == null || words == null || words.Length == 0) return res;
            int len = words[0].Length;

            var map = new Dictionary<string, int>();
            foreach (var w in words)
            {
                map[w] = map.ContainsKey(w) ? map[w] + 1 : 1;
            }

            for (int i = 0; i <= s.Length - len * words.Length; i++)
            {
                var copy = new Dictionary<string, int>(map);
                for (int j = 0; j < words.Length; j++)
                { 
                    String str = s.Substring(i + j * len, len);
                    if (copy.ContainsKey(str))
                    { 
                        int count = copy[str];
                        if (count == 1) 
                        { 
                            copy.Remove(str); 
                        }
                        else 
                        {
                            copy[str] = count - 1;                        
                        }
                        if (!copy.Any())
                        { 
                            res.Add(i);
                            break;
                        }
                    }
                    else break; 
                }
            }
            return res;
        }
}
```
### 31. Next Permutation
Medium
```c#
public class Solution {
    public void NextPermutation(int[] nums)
    {
        for (var i = nums.Length - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                var large = NextLarge(i, nums);
                (nums[i], nums[large]) = (nums[large], nums[i]);
                Reverse(i + 1, nums);
                return;
            }
        }

        Array.Reverse(nums);
    }

    public void Reverse(int idx, int[] nums)
    {
        var start = idx;
        var end = nums.Length - 1;

        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
    }

    public int NextLarge(int idx, int[] nums)
    {
        for (var i = nums.Length - 1; i > idx; i--)
        {
            if (nums[i] > nums[idx]) return i;
        }
        return 0;
    }
}
```
### 32. Longest Valid Parentheses
Hard
```c#
public class Solution {
        public int LongestValidParentheses(string s)
        {
            int left = 0, right = 0, maxlength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    left++;
                }
                else
                {
                    right++;
                }
                if (left == right)
                {
                    maxlength = Math.Max(maxlength, 2 * right);
                }
                else if (right >= left)
                {
                    left = right = 0;
                }
            }
            left = right = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == '(')
                {
                    left++;
                }
                else
                {
                    right++;
                }
                if (left == right)
                {
                    maxlength = Math.Max(maxlength, 2 * left);
                }
                else if (left >= right)
                {
                    left = right = 0;
                }
            }
            return maxlength;
        }
    
}
```
### 33. Search in Rotated Sorted Array
Medium
```c#
public class Solution {
    public int Search(int[] nums, int target) {
        return Array.FindIndex(nums, o=> o == target);
    }
}
```
### 34. Find First and Last Position of Element in Sorted Array
Medium
```c#
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        return new [] { Array.IndexOf(nums, target), Array.LastIndexOf(nums, target) };
    }
}
```
### 35. Search Insert Position
Easy
```c#
public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var n = nums.Length;
        var start = 0;
        var end = n - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
                start = mid + 1;
            else
                end = mid - 1;
        }

        return end + 1;
    }
}
```
### 36. Valid Sudoku
Medium
```c#
public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        int[] row = new int[9], col = new int[9], cub = new int[9];
        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                if (board[i][j] != '.')
                {
                    int idx = 1 << (board[i][j] - '0');
                    if (((row[i] & idx) != 0) || ((col[j] & idx) != 0) || ((cub[(i / 3) * 3 + j / 3] & idx) != 0)) return false;
                    row[i] |= idx;
                    col[j] |= idx;
                    cub[(i / 3) * 3 + j / 3] |= idx;
                }
            }
        }
        return true;
    }
}
```
### 37. Sudoku Solver
Hard
```c#
public class Solution {
    public void SolveSudoku(char[][] board) 
    { 
        Solve(board);
    }
    private bool Solve(char[][] board)
    {
        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.')
                {
                    for (char d = '1'; d <= '9'; d++)
                    {
                        if (IsValid(board, r, c, d))
                        {
                            board[r][c] = d;
                            if (Solve(board)) return true;
                            board[r][c] = '.';
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }
    private bool IsValid(char[][] board, int r, int c, char d)
    {
        for (int row = 0; row < 9; row++)
            if (board[row][c] == d) return false;
        for (int col = 0; col < 9; col++)
            if (board[r][col] == d) return false;
        for (int row = (r / 3) * 3; row < (r / 3 + 1) * 3; row++)
            for (int col = (c / 3) * 3; col < (c / 3 + 1) * 3; col++)
                if (board[row][col] == d) return false;
        return true;
    }
}
```
### 38. Count and Say
Medium
```c#
public class Solution {
    public string CountAndSay(int n)
    {
        if (n <= 0) return "-1";
        string result = "1";

        for (int i = 1; i < n; i++)
        {
            result = Build(result);
        }
        return result;
    }

    private string Build(string result)
    {
        var builder = new StringBuilder();
        int p = 0;
        while (p < result.Length)
        {
            char val = result[p];
            int count = 0;

            while (p < result.Length && result[p] == val)
            {
                p++;
                count++;
            }
            builder.Append(count);
            builder.Append(val);
        }
        return builder.ToString();
    }
}
```
### 39. Combination Sum
Medium
```c#
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var list = new List<IList<int>>();
        Array.Sort(candidates);
        BackTrack(list, new List<int>(), candidates, target, 0);
        return list;
    }

    private void BackTrack(List<IList<int>> list, List<int> buffer, int[] nums, int remain, int start)
    {
        if (remain < 0) return;
        else if (remain == 0) list.Add(new List<int>(buffer));
        else
        {
            for (int i = start; i < nums.Length; i++)
            {
                buffer.Add(nums[i]);
                BackTrack(list, buffer, nums, remain - nums[i], i);
                buffer.RemoveAt(buffer.Count - 1);
            }
        }
    }
}
```
### 40. Combination Sum II
Medium
```c#
public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        var list = new List<IList<int>>();
        Array.Sort(candidates);
        BackTrack(list, new List<int>(), candidates, target, 0);
        return list;
    }

    private void BackTrack(List<IList<int>> list, List<int> buffer, int[] nums, int remain, int start)
    {
        if (remain < 0) return;
        else if (remain == 0) list.Add(new List<int>(buffer));
        else
        {
            for (int i = start; i < nums.Length; i++)
            {
                if(i > start && nums[i] == nums[i-1]) continue;
                buffer.Add(nums[i]);
                BackTrack(list, buffer, nums, remain - nums[i], i + 1);
                buffer.RemoveAt(buffer.Count - 1);
            }
        }
    }
}
```
### 41. First Missing Positive
Hard
```c#
public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Array.Sort()
        var set = new HashSet<int>(nums);
        for(int i=1;i<5000004;i++)
        {
            if(!set.Contains(i)) return i;   
        }
        return 0;
    }
}
```
### 42. Trapping Rain Water
Hard
```c#
public class Solution {
    public int Trap(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int answer = 0;
        int left_max = 0, right_max = 0;
        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= left_max) left_max = height[left];
                else answer += left_max - height[left];
                ++left;
            }
            else
            {
                if (height[right] >= right_max) right_max = height[right];
                else answer += right_max - height[right];
                --right;
            }
        }
        return answer;
    }
}
```
### 43. Multiply Strings
Medium
```c#
public class Solution {
    public string Multiply(string num1, string num2) {
        int m = num1.Length, n = num2.Length;
        int[] pos = new int[m + n];

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 0; j--)
            {
                int mul = (num1[i] - '0') * (num2[j] - '0');
                int p1 = i + j, p2 = i + j + 1;
                int sum = mul + pos[p2];

                pos[p1] += sum / 10;
                pos[p2] = sum % 10;
            }
        }

        var sb = new StringBuilder();
        foreach (int p in pos) 
            if (!(sb.Length == 0 && p == 0)) sb.Append(p);
        return sb.Length == 0 ? "0" : sb.ToString();
    }
}
```
### 44. Wildcard Matching
Hard
```c#
using System.Text.RegularExpressions;  
public class Solution {
    public bool IsMatch(string text, string pattern) 
    {
        int s = 0, p = 0, match = 0, starIdx = -1;
        while (s < text.Length)
        {
            if (p < pattern.Length && (pattern[p] == '?' || text[s] == pattern[p]))
            {
                s++;
                p++;
            }
            else if (p < pattern.Length && pattern[p] == '*')
            {
                starIdx = p;
                match = s;
                p++;
            }
            else if (starIdx != -1)
            {
                p = starIdx + 1;
                match++;
                s = match;
            }
            else
            {
                return false;
            }
        }

        while (p < pattern.Length && pattern[p] == '*')
            p++;

        return p == pattern.Length;
    }
}
```
### 45. Jump Game II
Medium
```c#
public class Solution {
    public int Jump(int[] nums) {
        int jumps = 0, end = 0, most = 0;
        for (var i = 0; i < nums.Length - 1; i++)
        {
            most = Math.Max(most, i + nums[i]);
            if (i == end)
            {
                jumps++;
                end = most;
            }
        }
        return jumps;
    }
}
```
### 46. Permutations
Medium
```c#
public class Solution {
    public IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        var fact = new[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800 };
        for (int i = 1; i <= fact[nums.Length]; i++)
        {
            result.Add(Perms(i, nums, fact));
        }
        return result;
    }

    public List<int> Perms(int n, int[] s, int[] fact)
    {
        var sb = new List<int>();
        var s2 = s.ToList();
        n--;
        for (int i, g, sl = s2.Count; sl > 0; sl--, n = n % (g))
        {
            i = (int)Math.Floor((double)n / (g = fact[sl] / sl));
            sb.Add(s2[i]);
            s2.RemoveAt(i);
        }
        return sb;
    }
}
```
### 47. Permutations II
Medium
```c#
public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) 
    {
        var list = new List<IList<int>>();
        Array.Sort(nums);
        BackTrack(list, new List<int>(), nums, new bool[nums.Length]);
        return list;
    }

    private void BackTrack(List<IList<int>> list, List<int> buffer, int[] nums, bool[] used)
    {
        if (buffer.Count == nums.Length)
        {
            list.Add(new List<int>(buffer));
        }
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i] || i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
                used[i] = true;
                buffer.Add(nums[i]);
                BackTrack(list, buffer, nums, used);
                used[i] = false;
                buffer.RemoveAt(buffer.Count - 1);
            }
        }
    }
}
```
### 48. Rotate Image
Medium
```c#
public class Solution {
    public void Rotate(int[][] matrix)
    {
        int s = 0, e = matrix.Length - 1;
        while (s < e)
        {
            int[] temp = matrix[s];
            matrix[s++] = matrix[e];
            matrix[e--] = temp;
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = i + 1; j < matrix[i].Length; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }
}
```
### 49. Group Anagrams
Medium
```c#
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) =>
        strs.GroupBy(o => new string(o.OrderBy(x => x).ToArray()), o => o, (key, g) => (IList<string>)g.ToList()).ToList();    
}
```
### 50. Pow(x, n)
Medium
```c#
public class Solution {
    public double MyPow(double x, int n) {
        return Math.Pow(x, n);
    }
}
```
### 51. N-Queens
Hard
```c#
public class Solution {
    public IList<IList<string>> SolveNQueens(int n) 
    {
        var res = new List<IList<string>>();

        DFS(n, res, new List<int>(), new List<int>(), new List<int>());
        return res;
    }

    public void DFS(int n, List<IList<string>> res, List<int> queens, List<int> dif, List<int> sum)
    {
        var p = queens.Count;
        if (p == n)
        {
            var queens2 = (from i in queens
                           select (new string('.', i) + "Q" + new string('.', n - 1 - i))).ToList();
            res.Add(queens2);
            return;
        }
        foreach (var q in Enumerable.Range(0, n))
        {
            if (queens.Contains(q) || dif.Contains(p - q) || sum.Contains(p + q))
            {
                continue;
            }
            DFS(n, res, queens.Concat(new List<int> { q }).ToList(), dif.Concat(new List<int> { (p - q) }).ToList(), sum.Concat(new List<int> { (p + q) }).ToList());
        }
    }
}
```
### 52. N-Queens II
Hard
```c#
public class Solution {
    public int TotalNQueens(int n)
    {
        var res = new List<IList<string>>();

        DFS(n, res, new List<int>(), new List<int>(), new List<int>());
        return res.Count;
    }

    public void DFS(int n, List<IList<string>> res, List<int> queens, List<int> dif, List<int> sum)
    {
        var p = queens.Count;
        if (p == n)
        {
            var queens2 = (from i in queens
                           select (new string('.', i) + "Q" + new string('.', n - 1 - i))).ToList();
            res.Add(queens2);
            return;
        }
        foreach (var q in Enumerable.Range(0, n))
        {
            if (queens.Contains(q) || dif.Contains(p - q) || sum.Contains(p + q))
            {
                continue;
            }
            DFS(n, res, queens.Concat(new List<int> { q }).ToList(), dif.Concat(new List<int> { (p - q) }).ToList(), sum.Concat(new List<int> { (p + q) }).ToList());
        }
    }
}
```
### 53. Maximum Subarray
Easy
```c#
public class Solution {
    public int MaxSubArray(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return 0;
        int runSum = nums[0];
        int result = runSum;
        for (int end = 1; end < nums.Length; end++)
        {
            runSum = runSum + nums[end] >= nums[end] ? runSum + nums[end] : nums[end];
            result = Math.Max(runSum, result);
        }
        return result;
    }
}
```
### 54. Spiral Matrix
Medium
```c#
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int end = matrix.Length * matrix[0].Length;
        var result = new List<int>(end);
        for (int xMin = 0, yMin = 0, x = 0, y = 0, xMax = matrix[0].Length - 1, yMax = matrix.Length - 1; result.Count < end; xMin++)
        {
            for (x = xMin; x <= xMax && result.Count < end; x++) result.Add(matrix[yMin][x]);
            for (y = ++yMin; y <= yMax && result.Count < end; y++) result.Add(matrix[y][xMax]);
            for (x = --xMax; x >= xMin && result.Count < end; x--) result.Add(matrix[yMax][x]);
            for (y = --yMax; y >= yMin && result.Count < end; y--) result.Add(matrix[y][xMin]);
        }
        return result;
    }
}
```
### 55. Jump Game
Medium
```c#
public class Solution {
    public bool CanJump(int[] nums) {
        for (int i = 0, max = 0; i < nums.Length; max = (i + nums[i]) > max ? i + nums[i] : max, i++)
            if (max < i) return false;
        return true;
    }
}
```
### 56. Merge Intervals
Medium
```c#
public class Solution {
    public int[][] Merge(int[][] intervals)
    {
        var ordered = intervals.OrderBy(o => o[0]).ToList();
        var result = new List<int[]>();
        int[] last = null;
        foreach (var item in ordered)
        {
            if (last == null || item[0] > last[1])
                result.Add(last = item);
            else if (item[1] > last[1])
                last[1] = item[1];
        }
        return result.ToArray();
    }
}
```
### 57. Insert Interval
Medium
```c#
public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) 
    {
		var list = intervals.ToList();
		list.Add(newInterval);
        var ordered = list.OrderBy(o => o[0]).ToList();
        var result = new List<int[]>();
        int[] last = null;
        foreach (var item in ordered)
        {
            if (last == null || item[0] > last[1])
                result.Add(last = item);
            else if (item[1] > last[1])
                last[1] = item[1];
        }
        return result.ToArray();
    }
}
```
### 58. Length of Last Word
Easy
```c#
public class Solution {
    public int LengthOfLastWord(string s) {
        return s.Trim().Split(" ").Last().Length;
    }
}
```
### 59. Spiral Matrix II
Medium
```c#
public class Solution {
    public int[][] GenerateMatrix(int n) {
        int end = n * n, count = 0;
        int[][] result = new int[n][];
        for(int i = 0; i < n; i++)
            result[i] = new int[n];       
        for (int xMin = 0, yMin = 0, x = 0, y = 0, xMax = n - 1, yMax = n - 1; count < end; xMin++)
        {
            for (x = xMin; x <= xMax && count < end; x++) result[yMin][x] = ++count;
            for (y = ++yMin; y <= yMax && count < end; y++) result[y][xMax] = ++count;
            for (x = --xMax; x >= xMin && count < end; x--) result[yMax][x] = ++count;
            for (y = --yMax; y >= yMin && count < end; y--) result[y][xMin] = ++count;
        }
        return result;
    }
}
```
### 60. Permutation Sequence
Hard
```c#
public class Solution {
   public string GetPermutation(int n, int k)
    {
        var sb = new StringBuilder();
        var num = new List<int>();
        int fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            num.Add(i);
        }
        for (int i = 0, l = k - 1; i < n; i++)
        {
            fact /= n - i;
            int index = l / fact;
            sb.Append(num[index]);
            num.RemoveAt(index);
            l -= index * fact;
        }
        return sb.ToString();
    }
}
```
### 61. Rotate List
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
		if(head == null) return head;

		int length = 0;
		ListNode node = head;
		while(node != null){
			node = node.next;
			length++;
		}
		k = k % length;

		ListNode fpart, lpart;
		lpart = head;
		for(int i = 1; i < length - k; i++){
			head = head.next;
		}

		fpart = head.next;
		head.next = null;

		if(fpart == null) return lpart;
		node = fpart;
		while(node.next != null){
			node = node.next;
		}
		node.next = lpart;

		return fpart;
	}
}
```
### 62. Unique Paths
Medium
```c#
public class Solution {
    public int UniquePaths(int m, int n)
    {
        var location = new int[m, n];
        for (int i = 0; i < m; i++)        
            for (int j = 0; j < n; j++)            
                location[i, j] = (i == 0 || j == 0) 
                    ? 1
                    : location[i, j - 1] + location[i - 1, j];           
        return location[m - 1, n - 1];
    }
}
```
### 63. Unique Paths II
Medium
```c#
public class Solution {
    public int UniquePathsWithObstacles(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var dp = new int[m + 1, n+ 1];
        dp[1,1] = grid[0][0] != 1 ? 1 : 0;
        for (int i = 1; i <= m; i++)            
            for (int j = 1; j <= n; j++)                
                dp[i,j] += grid[i - 1][j - 1] != 1 ? dp[i,j - 1] + dp[i - 1,j] : 0;               
        return dp[m, n];
    }
}
```
### 64. Minimum Path Sum
Medium
```c#
public class Solution {
    public int MinPathSum(int[][] grid) {
        int m = grid.Length, n = grid[0].Length;
        var cur = new int[m];
        for (int i = 1; i < m; i++)
            cur[i] = cur[i - 1] + grid[i][0]; 
        for (int j = 1; j < n; j++) {
            cur[0] += grid[0][j]; 
            for (int i = 1; i < m; i++)
                cur[i] = Math.Min(cur[i - 1], cur[i]) + grid[i][j];
        }
        return cur[m - 1] + grid[0][0];
    }
}
```
### 65. Valid Number
Hard
```c#
using System.Text.RegularExpressions;
public class Solution {
    public bool IsNumber(string s) => new Regex(@"^[+-]?(\d+[.]?\d*|[.]\d+)(e[-+]?\d+)?$").IsMatch(s.ToLower().Trim());
}
```
### 66. Plus One
Easy
```c#
public class Solution {
    public int[] PlusOne(int[] digits)
    {
        int carry = 1;
        int index = digits.Length - 1;
        while (index >= 0 && carry > 0)
        {
            digits[index] = (digits[index] + carry) % 10;
            carry = digits[index] == 0 ? 1 : 0;
            index--;
        }

        if (carry > 0)
        {
            digits = new int[digits.Length + 1];
            digits[0] = 1;
        }

        return digits;
    }
}
```
### 67. Add Binary
Easy
```c#
public class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1; 
        int j = b.Length - 1;
        int c = 0;

        var str = new StringBuilder();
        while (i >= 0 || j >= 0 || c == 1) {
            c += i >= 0 ? a[i--] - '0': 0;
            c += j >= 0 ? b[j--] - '0': 0;
            str.Insert(0, (c & 1).ToString());
            c = c >> 1;
        }

        return str.ToString();
    }
}
```
### 68. Text Justification
Hard
```c#
public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        var result = new List<string>();
        for (int i = 0, w, len = -1; i < words.Length; i = w, len = -1)
        {
            for (w = i; w < words.Length && len + words[w].Length + 1 <= maxWidth; w++)                
                len += words[w].Length + 1;               
            var strBuilder = new StringBuilder(words[i]);
            int space = 1, extra = 0;
            if (w != i + 1 && w != words.Length)
                (space, extra) = ((maxWidth - len) / (w - i - 1) + 1, (maxWidth - len) % (w - i - 1));                
            for (int j = i + 1; j < w; j++)
            {
                for (int s = space; s > 0; s--) strBuilder.Append(' ');
                if (extra-- > 0) strBuilder.Append(' ');
                strBuilder.Append(words[j]);
            }
            int strLen = maxWidth - strBuilder.Length;
            while (strLen-- > 0) strBuilder.Append(' ');
            result.Add(strBuilder.ToString());
        }

        return result;
    }
}
```
### 69. Sqrt(x)
Easy
```c#
public class Solution {
    public int MySqrt(int x) {
        return (int)Math.Sqrt(x);
    }
}
```
### 70. Climbing Stairs
Easy
```c#
public class Solution {
    public int ClimbStairs(int n) {
        int a = 1, b = 1;
        while (n-- > 0)
            a = (b += a) - a;
        return a;
    }
}
```
### 71. Simplify Path
Medium
```c#
public class Solution {
    public string SimplifyPath(string path) {   
        return "/"+string.Join("/", Path.GetFullPath(path).Split("/").Where(o=>!string.IsNullOrEmpty(o)));
    }
}
```
### 72. Edit Distance
Hard
```c#
public class Solution {
    public int MinDistance(string word1, string word2) => LevenshteinDistance(word1.ToArray(), word2.ToArray());        
    public int LevenshteinDistance(char[] s1, char[] s2)
    {
        int s1p = s1.Length, s2p = s2.Length;
        int[,] num = new int[s1p + 1, s2p + 1];
        for (int i = 0; i <= s1p; i++)
            num[i,0] = i;
        for (int i = 0; i <= s2p; i++)
            num[0,i] = i;
        for (int i = 1; i <= s1p; i++)
            for (int j = 1; j <= s2p; j++)
                num[i,j] = Math.Min(Math.Min(num[i - 1,j] + 1,
                        num[i,j - 1] + 1), num[i - 1,j - 1]
                        + (s1[i - 1] == s2[j - 1] ? 0 : 1));
        return num[s1p,s2p];
    }
}
```
### 73. Set Matrix Zeroes
Medium
```c#
public class Solution {
    public void SetZeroes(int[][] matrix) {
        int col0 = 1, m = matrix.Length, n = matrix[0].Length;

        for (int i = 0; i < m; i++)
        {
            if (matrix[i][0] == 0) col0 = 0;
            for (int j = 1; j < n; j++)
                if (matrix[i][j] == 0)
                    matrix[i][0] = matrix[0][j] = 0;
        }

        for (int i = m - 1; i >= 0; i--)
        {
            for (int j = n - 1; j >= 1; j--)
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    matrix[i][j] = 0;
            if (col0 == 0) matrix[i][0] = 0;
        }
    }
}
```
### 74. Search a 2D Matrix
Medium
```c#
public class Solution {
    public bool SearchMatrix(int[][] grid, int target) 
    {
        int m = grid.Length, n = grid[0].Length;
        for (int j = 0; j < n; j++) 
            for (int i = 0; i < m; i++)
                if(grid[i][j] == target)
                    return true;
        return false;
    }
}
```
### 75. Sort Colors
Medium
```c#
public class Solution {
    //bucket sort
    public void SortColors(int[] nums) {
        int[] buckets = new int[3];
        foreach(int num in nums) buckets[num]++;
        for(int p = 0, val = 0; val < 3; val++) 
            for(int count = 0; count < buckets[val]; count++) 
                nums[p++] = val;           
    }
}
```
### 76. Minimum Window Substring
Hard
```c#
public class Solution {
    public string MinWindow(string input, string window)
    {
        var map = new int[256];
        foreach (var c in window) map[c]++;
        int counter = window.Length, begin = 0, end = 0, result = int.MaxValue, head = 0;
        while (end < input.Length)
        {
            if (map[input[end++]]-- > 0) counter--;
            while (counter == 0)
            {
                if (end - begin < result) result = end - (head = begin);
                if (map[input[begin++]]++ == 0) counter++;
            }
        }
        return result == int.MaxValue ? "" : input.Substring(head, result);
    }
}
```
### 77. Combinations
Medium
```c#
public class Solution {
    public IList<IList<int>> Combine(int n, int k)
    {
        var combs = new List<IList<int>>();
        Dfs(combs, new List<int>(), 1, n, k);
        return combs;
    }
    public void Dfs(List<IList<int>> combs, List<int> comb, int start, int n, int k)
    {
        if (k == 0)
        {
            combs.Add(new List<int>(comb));
            return;
        }
        for (int i = start; i <= n - k + 1; i++)
        {
            comb.Add(i);
            Dfs(combs, comb, i + 1, n, k - 1);
            comb.RemoveAt(comb.Count - 1);
        }
    }
}
```
### 78. Subsets
Medium
```c#
public class Solution {
    public IList<IList<int>> Subsets(int[] nums)
    {
        var list = new List<IList<int>>();
        Array.Sort(nums);
        BackTrack(list, new List<int>(), nums, 0);
        return list;
    }

    private void BackTrack(List<IList<int>> list, List<int> buffer, int[] nums, int start)
    {
        list.Add(new List<int>(buffer));
        for (int i = start; i < nums.Length; i++)
        {
            buffer.Add(nums[i]);
            BackTrack(list, buffer, nums, i + 1);
            buffer.RemoveAt(buffer.Count - 1);
        }
    }
}
```
### 79. Word Search
Medium
```c#
public class Solution {
    public bool Exist(char[][] board, string word)
    {
        int m = board.Length, n = board[0].Length;
        for (int i = 0; i < m; i++)            
            for (int j = 0; j < n; j++)                
                if (Search(board, i, j, word.ToArray(), 0))                    
                    return true;                  
        return false;
    }

    bool Search(char[][] board, int r, int c, char[] word, int wordI) 
    {
        if (word.Length == wordI) 
            return true;
        int m = board.Length, n = board[0].Length;
        if (r< 0 || r >= m || c< 0 || c >= n || board[r][c] != word[wordI])
            return false;        
        board[r][c] = (char)0;
        if (Search(board, r - 1 ,c, word, wordI+1) || Search(board, r + 1, c, word, wordI+1) ||
            Search(board, r, c - 1, word, wordI+1) || Search(board, r, c + 1, word, wordI+1))
            return true;        
        board[r][c] = word[wordI];
        return false;
    }
}
```
### 80. Remove Duplicates from Sorted Array II
Medium
```c#
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        foreach (var n in nums)
            if (i < 2 || n > nums[i-2])
                nums[i++] = n;
        return i;
    }
}
```
### 81. Search in Rotated Sorted Array II
Medium
```c#
public class Solution {
    public bool Search(int[] nums, int target) {
        return Array.FindIndex(nums, o=> o == target) >= 0;
    }
}
```
### 82. Remove Duplicates from Sorted List II
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
      	var list = new List<ListNode>();
        for (ListNode i = head; i != null; i = i.next)
        {
            list.Add(i);
        }
		var withoutDuplicates = list.GroupBy(o=>o.val).Where(g=>g.Count()==1).Select(o=>o.First()).ToList();
		int count = 0;
        foreach(var i in withoutDuplicates)
        {
			i.next = (++count < withoutDuplicates.Count) 
				? withoutDuplicates[count] 
				: null;
        }
        return withoutDuplicates.FirstOrDefault();
    }
}
```
### 83. Remove Duplicates from Sorted List
Easy
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head)
    {
        for (ListNode i = head; i != null; i = i.next)
        {
            while (i.next != null && i.val == i.next.val)
                i.next = i.next?.next;
        }
        return head;
    }
}
```
### 84. Largest Rectangle in Histogram
Hard
```c#
public class Solution {
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length, max = 0, counter = -1;
        var stack = new int[n + 1];
        for (int i = 0; i <= n; stack[++counter] = i++)
        {
            int height = (i == n) ? 0 : heights[i];
            while (counter != -1 && height < heights[stack[counter]])
                max = Math.Max(max, heights[stack[counter--]] * ((counter == -1) ? i : i - 1 - stack[counter]));
        }
        return max;
    }
}
```
### 85. Maximal Rectangle
Hard
```c#
public class Solution {
    public int MaximalRectangle(char[][] matrix)
    {
        if (matrix.Length == 0) return 0;
        int n = matrix[0].Length, max = 0; 
        var heights = new int[n]; 
        foreach (char[] row in matrix)
        {
            for (int i = 0; i < n; i++)                
                heights[i] = (row[i] == '1') ? heights[i] + 1 : 0;                   
            max = Math.Max(max, LargestRectangleArea(heights));
        }
        return max;
    }
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length, max = 0, counter = -1;
        var stack = new int[n + 1];
        for (int i = 0; i <= n; stack[++counter] = i++)
        {
            int height = (i == n) ? 0 : heights[i];
            while (counter != -1 && height < heights[stack[counter]])
                max = Math.Max(max, heights[stack[counter--]] * ((counter == -1) ? i : i - 1 - stack[counter]));
        }
        return max;
    }
}
```
### 86. Partition List
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode Partition(ListNode head, int x)
    {
        ListNode minNode = new ListNode(0), maxNode = new ListNode(0), min = minNode, max = maxNode;
        for (; head != null; head = head.next)            
            if (head.val < x)
                min = min.next = head;
            else
                max = max.next = head;      
        min.next = maxNode.next;
        max.next = null;
        return minNode.next;
    }
}
```
### 87. Scramble String
Hard
```c#
public class Solution {
    public bool IsScramble(string s1, string s2) 
    {
        if (s1.Length != s2.Length) 
            return false;
        
        var len = s1.Length;
        return IsRangeScramble(s1, s2, 0, 0, s1.Length, new byte[len, len, len + 1]) == TRUE;
    }
    
    const byte NA = 0;
    const byte TRUE = 1;
    const byte FALSE = 2;
    
    public byte IsRangeScramble(string s1, string s2, int i, int j, int length, byte[,,] dp)
    {
        if (length <= 1)
        {
            return length == 0 || s1[i] == s2[j] ? TRUE : FALSE;
        }
        
        var canScramble = dp[i, j, length];
        if (canScramble == NA)
        {
            for (int firstLen = 1; firstLen < length && canScramble != TRUE; firstLen++)
            {
                var secondLen = length - firstLen;
                if ((IsRangeScramble(s1, s2, i, j, firstLen, dp) == TRUE && 
                     IsRangeScramble(s1, s2, i + firstLen, j + firstLen, secondLen, dp) == TRUE) ||
                    (IsRangeScramble(s1, s2, i + secondLen, j, firstLen, dp) == TRUE && 
                     IsRangeScramble(s1, s2, i, j + firstLen, length - firstLen, dp) == TRUE))
                {
                    canScramble = TRUE;
                }
            }
            return (dp[i, j, length] = (canScramble == TRUE ? TRUE : FALSE));
        }
        return canScramble;
    }
}
```
### 88. Merge Sorted Array
Easy
```c#
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        Buffer.BlockCopy(nums2, 0 * 4, nums1, (m) * 4, (n) * 4);
        Array.Sort(nums1);
    }
}
```
### 89. Gray Code
Medium
```c#
public class Solution {
    public IList<int> GrayCode(int n) {
        var result = new List<int>();
        for (int i = 0; i < 1<<n; i++) 
            result.Add(i ^ i>>1);
        return result;
    }
}
```
### 90. Subsets II
Medium
```c#
public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) 
    {
        var list = new List<IList<int>>();
        Array.Sort(nums);
        BackTrack(list, new List<int>(), nums, 0);
        return list;
    }

    private void BackTrack(List<IList<int>> list, List<int> buffer, int[] nums, int start)
    {
        list.Add(new List<int>(buffer));
        for (int i = start; i < nums.Length; i++)
        {
            if(i > start && nums[i] == nums[i-1]) continue;
            buffer.Add(nums[i]);
            BackTrack(list, buffer, nums, i + 1);
            buffer.RemoveAt(buffer.Count - 1);
        }
    }
}
```
### 91. Decode Ways
Medium
```c#
public class Solution {
    public int NumDecodings(string s)
    {
        if (s == null || s.Length == 0)
        {
            return 0;
        }
        var chars = s.ToArray();
        var dp = new int[chars.Length];
        dp[0] = chars[0] == '0' ? 0 : 1;
        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] >= '1' && chars[i] <= '9')                
                dp[i] = dp[i - 1];                
            if ((chars[i - 1] == '1' && chars[i] >= '0' && chars[i] <= '9') 
                || (chars[i - 1] == '2' && chars[i] >= '0' && chars[i] <= '6'))                
                dp[i] += i >= 2 ? dp[i - 2] : 1;                
        }
        return dp[chars.Length - 1];
    }
}
```
### 92. Reverse Linked List II
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var list = new List<ListNode>();
        for (ListNode i = head; i != null; i = i.next)
            list.Add(i);
        var result = list.Take(left-1)
            .Concat(list.Skip(left-1).Take(right - left + 1).Reverse())
            .Concat(list.Skip(right)).ToList();
        var count = 0;
        foreach(var item in result)
            item.next = (++count < result.Count) ? result[count] : null;
        return result.FirstOrDefault();
    }
}
```
### 93. Restore IP Addresses
Medium
```c#
public class Solution {
    public IList<string> RestoreIpAddresses(string s)
    {
        int[] n;
        var ret = new List<string>();
        var ip = new StringBuilder();
        for (int a = 1; a < 4; ++a)
            for (int b = 1; b < 4; ++b)
                for (int c = 1; c < 4; ++c)
                    for (int d = 1; d < 4; ++d)						
                        if (a + b + c + d == s.Length)
                            if ((n = new int[] {
                                int.Parse(s.Substring(0, a)),
                                int.Parse(s.Substring(a, b)),
                                int.Parse(s.Substring(a + b, c)),
                                int.Parse(s.Substring(a + b + c, s.Length - a - b - c)),
                            }).All(o => o <= 255))
                            {
                                ip.Append($"{n[0]}.{n[1]}.{n[2]}.{n[3]}");
                                if (ip.Length == s.Length + 3) ret.Add(ip.ToString());
                                ip.Remove(0, ip.Length);
                            }						
        return ret;
    }
}
```
### 94. Binary Tree Inorder Traversal
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> list = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode node = root;
        while (node != null || stack.Count > 0)
        {
            if (node != null)
            {
                stack.Push(node);
                node = node.left;
            }
            else
            {
                node = stack.Pop();
                list.Add(node.val);
                node = node.right;
            }
        }
        
        return list;
    }
}
```
### 95. Unique Binary Search Trees II
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<TreeNode> GenerateTrees(int n)
    {
        var result = new List<TreeNode>();
        if (n == 0)        
            return result;        
        result.Add(null);
        for (int i = 1; i <= n; i++)
        {
            var temp = new List<TreeNode>();
            foreach (var node in result)
            {
                var root = new TreeNode(i) { left = DeepCopy(node) };
                temp.Add(root);

                if (node == null)
                {
                    continue;
                }
                var item = node;
                while (item.right != null)
                {
                    root = new TreeNode(i);
                    var swap = item.right;
                    item.right = root;
                    root.left = swap;
                    temp.Add(DeepCopy(node));
                    item.right = swap;
                    item = item.right;
                }
                root = new TreeNode(i);
                item.right = root;
                temp.Add(DeepCopy(node));
                item.right = null;
            }
            result = new List<TreeNode>(temp);
        }
        return result;
    }

    private TreeNode DeepCopy(TreeNode root) => root == null
        ? null
        : new TreeNode(root.val)
        {
            left = DeepCopy(root.left),
            right = DeepCopy(root.right)
        };
}
```
### 96. Unique Binary Search Trees
Medium
```c#
public class Solution {
    Dictionary<int, int> map = new Dictionary<int, int>
    {   
        {0, 1}, 
        {1, 1}
    };
    public int NumTrees(int n, int sum = 0) 
    {        
        if(map.ContainsKey(n)) return map[n];
        for(int i = 1; i <= n; i++)
            sum += NumTrees(i-1) * NumTrees(n-i);
        return map[n] = sum;
    }
}
```
### 97. Interleaving String
Medium
```c#
public class Solution {
    public bool IsInterleave(string s1, string s2, string s3)
    {
        var len = new int[] { s1.Length, s2.Length, s3.Length };            
        if (len[0] > len[1]) return IsInterleave(s2, s1, s3);
        if (len[2] != len[0] + len[1]) return false;
        var dp = new bool[len[0] + 1];
        dp[0] = true;
        for (int i = 1; i <= len[0]; i++)
            dp[i] = dp[i - 1] && s3[i - 1] == s1[i - 1];
        for (int j = 1; j <= len[1]; j++) {
            dp[0] = dp[0] && s3[j - 1] == s2[j - 1];
            for (int i = 1; i <= len[0]; i++)
                dp[i] = (dp[i - 1] && s3[i + j - 1] == s1[i - 1]) || (dp[i] && s3[i + j - 1] == s2[j - 1]);
        }
        return dp[len[0]];
    }
}
```
### 98. Validate Binary Search Tree
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) => BackTrack(root, null, null);
    private bool BackTrack(TreeNode root, int? low, int? high)
    {
        if (root == null) return true;
        if (low != null && root.val <= low || high != null && root.val >= high) return false;
        return BackTrack(root.left, low, root.val) && BackTrack(root.right, root.val, high);
    }
}
```
### 99. Recover Binary Search Tree
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    TreeNode last = null;
    TreeNode a = null;
    TreeNode b = null;
    public void RecoverTree(TreeNode root)
    {
        BackTrack(root);
        Swap(ref a.val, ref b.val);
    }
    private void BackTrack(TreeNode node)
    {
        if (node == null) return;
        BackTrack(node.left);
        if (last != null)
        {
            if (last.val >= node.val)
            {
                if (a == null)
                    a = last;
                b = node;
            }
        }
        last = node;
        BackTrack(node.right);
    }
    private void Swap<T>(ref T i, ref T j)
    {
        T swap = i;
        i = j;
        j = swap;
    }
}
```
### 100. Same Tree
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true;
        if(p == null || q == null) return false;
        if(p.val == q.val)
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        return false;
    }
}
```
### 101. Symmetric Tree
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) => root == null || Compare(root.left, root.right);
    private bool Compare(TreeNode left, TreeNode right)
    {
        if (left == null || right == null)
            return left == right;
        if (left.val != right.val)
            return false;
        return Compare(left.left, right.right) &&
               Compare(left.right, right.left);
    }
}
```
### 102. Binary Tree Level Order Traversal
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) => Visitor(root, 0, new List<IList<int>>());
    private IList<IList<int>> Visitor(TreeNode root, int level, List<IList<int>> result)
    {
        if (root == null)
            return result;			
        if (level == result.Count)
            result.Add(new List<int>());
        result[level].Add(root.val);
        Visitor(root.left, level + 1, result);
        Visitor(root.right, level + 1, result);
        return result;
    }
}
```
### 103. Binary Tree Zigzag Level Order Traversal
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) 
    {
        var result = Visitor(root, 0, new List<IList<int>>());
        for(var i = 0; i < result.Count; i++)        
            if(i % 2 == 1)            
                result[i] = result[i].Reverse().ToList();
        return result;
    }
    private IList<IList<int>> Visitor(TreeNode root, int level, List<IList<int>> result)
    {
        if (root == null)
            return result;			
        if (level == result.Count)
            result.Add(new List<int>());
        result[level].Add(root.val);
        Visitor(root.left, level + 1, result);
        Visitor(root.right, level + 1, result);
        return result;
    }
}
```
### 104. Maximum Depth of Binary Tree
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) => root == null ? 0 : 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
}
```
### 105. Construct Binary Tree from Preorder and Inorder Traversal
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {    
    public TreeNode BuildTree(int[] preorder, int[] inorder, int inCount = 0, int preCount = 0) => 
        Visitor(preorder, inorder, int.MinValue, ref inCount, ref preCount);    
    private TreeNode Visitor(int[] preorder, int[] inorder, int stop, ref int inCount, ref int preCount)
    {
        if (preCount >= preorder.Length) 
            return null;
        if (inorder[inCount] == stop) {
            inCount++;
            return null;
        }
        return new TreeNode(preorder[preCount++])
        {
            left = Visitor(preorder, inorder, preorder[preCount-1], ref inCount, ref preCount),
            right = Visitor(preorder, inorder, stop, ref inCount, ref preCount),
        };       
    }
}
```
### 106. Construct Binary Tree from Inorder and Postorder Traversal
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) => ToBST(head, null);
    private TreeNode ToBST(ListNode head, ListNode tail)
    {
        if (head == null || head == tail)
            return null;
        if (head.next == tail)
            return new TreeNode(head.val);
        ListNode fast = head, slow = head;
        while (fast != tail && fast.next != tail)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return new TreeNode(slow.val)
        {
            left = ToBST(head, slow),
            right = ToBST(slow.next, tail)
        };
    }
}
```
### 107. Binary Tree Level Order Traversal II
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) => Visitor(root, 0, new List<IList<int>>()).Reverse().ToList();
    private IList<IList<int>> Visitor(TreeNode root, int level, List<IList<int>> result)
    {
        if (root == null)
            return result;			
        if (level == result.Count)
            result.Add(new List<int>());
        result[level].Add(root.val);
        Visitor(root.left, level + 1, result);
        Visitor(root.right, level + 1, result);
        return result;
    }
}
```
### 108. Convert Sorted Array to Binary Search Tree
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedArrayToBST(int[] nums) => SortedArrayToBST(nums, 0, nums.Length - 1);
    public TreeNode SortedArrayToBST(int[] nums, int lower, int higher)
    {
        if (lower > higher) return null;
        int mid = (higher - lower) / 2 + lower;
        return new TreeNode(nums[mid])
        {
            left = SortedArrayToBST(nums, lower, mid - 1),
            right = SortedArrayToBST(nums, mid + 1, higher)
        };
    }
}
```
### 109. Convert Sorted List to Binary Search Tree
Medium
```c#
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode SortedListToBST(ListNode head) => ToBST(head, null);
    private TreeNode ToBST(ListNode head, ListNode tail)
    {
        if (head == null || head == tail)
            return null;
        if (head.next == tail)
            return new TreeNode(head.val);
        ListNode fast = head, slow = head;
        while (fast != tail && fast.next != tail)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return new TreeNode(slow.val)
        {
            left = ToBST(head, slow),
            right = ToBST(slow.next, tail)
        };
    }
}
```
### 110. Balanced Binary Tree
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsBalanced(TreeNode root) {
        return Height(root) != -1;
    }
    
    int Height (TreeNode root, int l = 0, int r = 0) 
    {        
        if (root == null) return 0;    
        if ((l = Height(root.left)) == -1) return -1;
        if ((r = Height(root.right)) == -1) return -1;        
        if (Math.Abs(l - r) > 1)  return -1;
        return Math.Max(l, r) + 1;
    }
}
```
### 111. Minimum Depth of Binary Tree
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MinDepth(TreeNode root) 
    {
        if (root == null) 
            return 0;
        int L = MinDepth(root.left);
        int R = MinDepth(root.right);
        return L < R && L > 0 || R < 1 
            ? 1 + L 
            : 1 + R;
    }
}
```
### 112. Path Sum
Easy
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if(root == null) return false;
        if(root.left == null && root.right == null) return root.val == sum;
        return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
    }
}
```
### 113. Path Sum II
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        var paths = new List<IList<int>>();
        FindPaths(root, targetSum, new List<int>(), paths);
        return paths;
    }

    public void FindPaths(TreeNode node, int targetSum, IList<int> path, IList<IList<int>> paths)
    {
        if (node == null) 
            return;
        path.Add(node.val);
        if (node.left == null && node.right == null && targetSum == node.val)
            paths.Add(path.ToList());
        FindPaths(node.left, targetSum - node.val, path, paths);
        FindPaths(node.right, targetSum - node.val, path, paths);
        path.RemoveAt(path.Count - 1);
    }
}
```
### 114. Flatten Binary Tree to Linked List
Medium
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public void Flatten(TreeNode root)
    {
        while (root != null)
        {
            if (root.left != null)
            {
                TreeNode prev = root.left;
                while (prev.right != null)                
                    prev = prev.right;                
                prev.right = root.right;
                root.right = root.left;
                root.left = null;
            }
            root = root.right;
        }
    }
}
```
### 115. Distinct Subsequences
Hard
```c#
public class Solution {
    public int NumDistinct(string a, string b)
    {
        if (a == null || b == null) return 0;
        var mem = new int[a.Length, b.Length];
        for (int i = 0; i < mem.GetLength(0); i++)
            for (int j = 0; j < mem.GetLength(1); j++)
                mem[i, j] = -1;
        return BackTrack(a, b, mem, 0, 0);
    }
    private int BackTrack(string a, string b, int[,] mem, int aFrom, int bFrom)
    {
        if (aFrom == a.Length && bFrom < b.Length) return 0;
        if (bFrom == b.Length) return 1;
        if (mem[aFrom, bFrom] != -1) return mem[aFrom, bFrom];
        return a[aFrom] == b[bFrom]
            ? (mem[aFrom, bFrom] = BackTrack(a, b, mem, aFrom + 1, bFrom) + BackTrack(a, b, mem, aFrom + 1, bFrom + 1))
            : (mem[aFrom, bFrom] = BackTrack(a, b, mem, aFrom + 1, bFrom));
    }
}
```
### 116. Populating Next Right Pointers in Each Node
Medium
```c#
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root)
    {
        var level_start = root;
        while (level_start != null)
        {
            var current = level_start;
            while (current != null)
            {
                if (current.left != null) current.left.next = current.right;
                if (current.right != null && current.next != null) current.right.next = current.next.left;

                current = current.next;
            }
            level_start = level_start.left;
        }
        return root;
    }
}
```
### 117. Populating Next Right Pointers in Each Node II
Medium
```c#
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root)
	{
		if (root == null)
		{
			return null;
		}
		var location = root;
		var next = new Node(0);
		var current = next;
		while (location != null)
		{
			if (location.left != null)
			{
				current.next = location.left;
				current = current.next;
			}
			if (location.right != null)
			{
				current.next = location.right;
				current = current.next;
			}
			if (location.next != null)
			{
				location = location.next;
			}
			else
			{
				location = next.next;
				next.next = null;
				current = next;
			}
		}
        return root;
	}
}
```
### 118. Pascal's Triangle
Easy
```c#
public class Solution {
private System.Numerics.BigInteger[] factorial = new string[] { "1", "1", "2", "6", "24", "120", "720", "5040", "40320", "362880", "3628800", "39916800", "479001600", "6227020800", "87178291200", "1307674368000", "20922789888000", "355687428096000", "6402373705728000", "121645100408832000", "2432902008176640000", "51090942171709440000", "1124000727777607680000", "25852016738884976640000", "620448401733239439360000", "15511210043330985984000000", "403291461126605635584000000", "10888869450418352160768000000", "304888344611713860501504000000", "8841761993739701954543616000000", "265252859812191058636308480000000", "8222838654177922817725562880000000", "263130836933693530167218012160000000", "8683317618811886495518194401280000000", "295232799039604140847618609643520000000", "10333147966386144929666651337523200000000", "371993326789901217467999448150835200000000", "13763753091226345046315979581580902400000000", "523022617466601111760007224100074291200000000", "20397882081197443358640281739902897356800000000", "815915283247897734345611269596115894272000000000", "33452526613163807108170062053440751665152000000000", "1405006117752879898543142606244511569936384000000000", "60415263063373835637355132068513997507264512000000000", "2658271574788448768043625811014615890319638528000000000", "119622220865480194561963161495657715064383733760000000000", "5502622159812088949850305428800254892961651752960000000000", "258623241511168180642964355153611979969197632389120000000000", "12413915592536072670862289047373375038521486354677760000000000", "608281864034267560872252163321295376887552831379210240000000000", "30414093201713378043612608166064768844377641568960512000000000000", "1551118753287382280224243016469303211063259720016986112000000000000", "80658175170943878571660636856403766975289505440883277824000000000000", "4274883284060025564298013753389399649690343788366813724672000000000000", "230843697339241380472092742683027581083278564571807941132288000000000000", "12696403353658275925965100847566516959580321051449436762275840000000000000", "710998587804863451854045647463724949736497978881168458687447040000000000000", "40526919504877216755680601905432322134980384796226602145184481280000000000000", "2350561331282878571829474910515074683828862318181142924420699914240000000000000", "138683118545689835737939019720389406345902876772687432540821294940160000000000000", "8320987112741390144276341183223364380754172606361245952449277696409600000000000000", "507580213877224798800856812176625227226004528988036003099405939480985600000000000000", "31469973260387937525653122354950764088012280797258232192163168247821107200000000000000", "1982608315404440064116146708361898137544773690227268628106279599612729753600000000000000", "126886932185884164103433389335161480802865516174545192198801894375214704230400000000000000", "8247650592082470666723170306785496252186258551345437492922123134388955774976000000000000000", "544344939077443064003729240247842752644293064388798874532860126869671081148416000000000000000", "36471110918188685288249859096605464427167635314049524593701628500267962436943872000000000000000", "2480035542436830599600990418569171581047399201355367672371710738018221445712183296000000000000000", "171122452428141311372468338881272839092270544893520369393648040923257279754140647424000000000000000", "11978571669969891796072783721689098736458938142546425857555362864628009582789845319680000000000000000", "850478588567862317521167644239926010288584608120796235886430763388588680378079017697280000000000000000", "61234458376886086861524070385274672740778091784697328983823014963978384987221689274204160000000000000000", "4470115461512684340891257138125051110076800700282905015819080092370422104067183317016903680000000000000000", "330788544151938641225953028221253782145683251820934971170611926835411235700971565459250872320000000000000000", "24809140811395398091946477116594033660926243886570122837795894512655842677572867409443815424000000000000000000", "1885494701666050254987932260861146558230394535379329335672487982961844043495537923117729972224000000000000000000", "145183092028285869634070784086308284983740379224208358846781574688061991349156420080065207861248000000000000000000", "11324281178206297831457521158732046228731749579488251990048962825668835325234200766245086213177344000000000000000000", "894618213078297528685144171539831652069808216779571907213868063227837990693501860533361810841010176000000000000000000", "71569457046263802294811533723186532165584657342365752577109445058227039255480148842668944867280814080000000000000000000", "5797126020747367985879734231578109105412357244731625958745865049716390179693892056256184534249745940480000000000000000000", "475364333701284174842138206989404946643813294067993328617160934076743994734899148613007131808479167119360000000000000000000", "39455239697206586511897471180120610571436503407643446275224357528369751562996629334879591940103770870906880000000000000000000", "3314240134565353266999387579130131288000666286242049487118846032383059131291716864129885722968716753156177920000000000000000000", "281710411438055027694947944226061159480056634330574206405101912752560026159795933451040286452340924018275123200000000000000000000", "24227095383672732381765523203441259715284870552429381750838764496720162249742450276789464634901319465571660595200000000000000000000", "2107757298379527717213600518699389595229783738061356212322972511214654115727593174080683423236414793504734471782400000000000000000000", "185482642257398439114796845645546284380220968949399346684421580986889562184028199319100141244804501828416633516851200000000000000000000", "16507955160908461081216919262453619309839666236496541854913520707833171034378509739399912570787600662729080382999756800000000000000000000", "1485715964481761497309522733620825737885569961284688766942216863704985393094065876545992131370884059645617234469978112000000000000000000000", "135200152767840296255166568759495142147586866476906677791741734597153670771559994765685283954750449427751168336768008192000000000000000000000", "12438414054641307255475324325873553077577991715875414356840239582938137710983519518443046123837041347353107486982656753664000000000000000000000", "1156772507081641574759205162306240436214753229576413535186142281213246807121467315215203289516844845303838996289387078090752000000000000000000000", "108736615665674308027365285256786601004186803580182872307497374434045199869417927630229109214583415458560865651202385340530688000000000000000000000", "10329978488239059262599702099394727095397746340117372869212250571234293987594703124871765375385424468563282236864226607350415360000000000000000000000", "991677934870949689209571401541893801158183648651267795444376054838492222809091499987689476037000748982075094738965754305639874560000000000000000000000", "96192759682482119853328425949563698712343813919172976158104477319333745612481875498805879175589072651261284189679678167647067832320000000000000000000000", "9426890448883247745626185743057242473809693764078951663494238777294707070023223798882976159207729119823605850588608460429412647567360000000000000000000000", "933262154439441526816992388562667004907159682643816214685929638952175999932299156089414639761565182862536979208272237582511852109168640000000000000000000000", "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000" }.Select(o => System.Numerics.BigInteger.Parse(o)).ToArray();
private System.Numerics.BigInteger Binomial(int n, int k) => System.Numerics.BigInteger.Divide(factorial[n], System.Numerics.BigInteger.Multiply(factorial[k], factorial[n - k]));
public IList<IList<int>> Generate(int numRows) => Enumerable.Range(0, numRows)
    .Select(n => (IList<int>)Enumerable.Range(0, n + 1).Select(k => (int)Binomial(n, k)).ToList()).ToList();
}
```
### 119. Pascal's Triangle II
Easy
```c#
public class Solution {
    public IList<int> GetRow(int rowIndex) {
        return Enumerable.Range(0, rowIndex + 1).Select(k => (int)Binomial(rowIndex, k)).ToList();
    }
    private System.Numerics.BigInteger[] factorial = new string[] { "1", "1", "2", "6", "24", "120", "720", "5040", "40320", "362880", "3628800", "39916800", "479001600", "6227020800", "87178291200", "1307674368000", "20922789888000", "355687428096000", "6402373705728000", "121645100408832000", "2432902008176640000", "51090942171709440000", "1124000727777607680000", "25852016738884976640000", "620448401733239439360000", "15511210043330985984000000", "403291461126605635584000000", "10888869450418352160768000000", "304888344611713860501504000000", "8841761993739701954543616000000", "265252859812191058636308480000000", "8222838654177922817725562880000000", "263130836933693530167218012160000000", "8683317618811886495518194401280000000", "295232799039604140847618609643520000000", "10333147966386144929666651337523200000000", "371993326789901217467999448150835200000000", "13763753091226345046315979581580902400000000", "523022617466601111760007224100074291200000000", "20397882081197443358640281739902897356800000000", "815915283247897734345611269596115894272000000000", "33452526613163807108170062053440751665152000000000", "1405006117752879898543142606244511569936384000000000", "60415263063373835637355132068513997507264512000000000", "2658271574788448768043625811014615890319638528000000000", "119622220865480194561963161495657715064383733760000000000", "5502622159812088949850305428800254892961651752960000000000", "258623241511168180642964355153611979969197632389120000000000", "12413915592536072670862289047373375038521486354677760000000000", "608281864034267560872252163321295376887552831379210240000000000", "30414093201713378043612608166064768844377641568960512000000000000", "1551118753287382280224243016469303211063259720016986112000000000000", "80658175170943878571660636856403766975289505440883277824000000000000", "4274883284060025564298013753389399649690343788366813724672000000000000", "230843697339241380472092742683027581083278564571807941132288000000000000", "12696403353658275925965100847566516959580321051449436762275840000000000000", "710998587804863451854045647463724949736497978881168458687447040000000000000", "40526919504877216755680601905432322134980384796226602145184481280000000000000", "2350561331282878571829474910515074683828862318181142924420699914240000000000000", "138683118545689835737939019720389406345902876772687432540821294940160000000000000", "8320987112741390144276341183223364380754172606361245952449277696409600000000000000", "507580213877224798800856812176625227226004528988036003099405939480985600000000000000", "31469973260387937525653122354950764088012280797258232192163168247821107200000000000000", "1982608315404440064116146708361898137544773690227268628106279599612729753600000000000000", "126886932185884164103433389335161480802865516174545192198801894375214704230400000000000000", "8247650592082470666723170306785496252186258551345437492922123134388955774976000000000000000", "544344939077443064003729240247842752644293064388798874532860126869671081148416000000000000000", "36471110918188685288249859096605464427167635314049524593701628500267962436943872000000000000000", "2480035542436830599600990418569171581047399201355367672371710738018221445712183296000000000000000", "171122452428141311372468338881272839092270544893520369393648040923257279754140647424000000000000000", "11978571669969891796072783721689098736458938142546425857555362864628009582789845319680000000000000000", "850478588567862317521167644239926010288584608120796235886430763388588680378079017697280000000000000000", "61234458376886086861524070385274672740778091784697328983823014963978384987221689274204160000000000000000", "4470115461512684340891257138125051110076800700282905015819080092370422104067183317016903680000000000000000", "330788544151938641225953028221253782145683251820934971170611926835411235700971565459250872320000000000000000", "24809140811395398091946477116594033660926243886570122837795894512655842677572867409443815424000000000000000000", "1885494701666050254987932260861146558230394535379329335672487982961844043495537923117729972224000000000000000000", "145183092028285869634070784086308284983740379224208358846781574688061991349156420080065207861248000000000000000000", "11324281178206297831457521158732046228731749579488251990048962825668835325234200766245086213177344000000000000000000", "894618213078297528685144171539831652069808216779571907213868063227837990693501860533361810841010176000000000000000000", "71569457046263802294811533723186532165584657342365752577109445058227039255480148842668944867280814080000000000000000000", "5797126020747367985879734231578109105412357244731625958745865049716390179693892056256184534249745940480000000000000000000", "475364333701284174842138206989404946643813294067993328617160934076743994734899148613007131808479167119360000000000000000000", "39455239697206586511897471180120610571436503407643446275224357528369751562996629334879591940103770870906880000000000000000000", "3314240134565353266999387579130131288000666286242049487118846032383059131291716864129885722968716753156177920000000000000000000", "281710411438055027694947944226061159480056634330574206405101912752560026159795933451040286452340924018275123200000000000000000000", "24227095383672732381765523203441259715284870552429381750838764496720162249742450276789464634901319465571660595200000000000000000000", "2107757298379527717213600518699389595229783738061356212322972511214654115727593174080683423236414793504734471782400000000000000000000", "185482642257398439114796845645546284380220968949399346684421580986889562184028199319100141244804501828416633516851200000000000000000000", "16507955160908461081216919262453619309839666236496541854913520707833171034378509739399912570787600662729080382999756800000000000000000000", "1485715964481761497309522733620825737885569961284688766942216863704985393094065876545992131370884059645617234469978112000000000000000000000", "135200152767840296255166568759495142147586866476906677791741734597153670771559994765685283954750449427751168336768008192000000000000000000000", "12438414054641307255475324325873553077577991715875414356840239582938137710983519518443046123837041347353107486982656753664000000000000000000000", "1156772507081641574759205162306240436214753229576413535186142281213246807121467315215203289516844845303838996289387078090752000000000000000000000", "108736615665674308027365285256786601004186803580182872307497374434045199869417927630229109214583415458560865651202385340530688000000000000000000000", "10329978488239059262599702099394727095397746340117372869212250571234293987594703124871765375385424468563282236864226607350415360000000000000000000000", "991677934870949689209571401541893801158183648651267795444376054838492222809091499987689476037000748982075094738965754305639874560000000000000000000000", "96192759682482119853328425949563698712343813919172976158104477319333745612481875498805879175589072651261284189679678167647067832320000000000000000000000", "9426890448883247745626185743057242473809693764078951663494238777294707070023223798882976159207729119823605850588608460429412647567360000000000000000000000", "933262154439441526816992388562667004907159682643816214685929638952175999932299156089414639761565182862536979208272237582511852109168640000000000000000000000", "93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000" }.Select(o => System.Numerics.BigInteger.Parse(o)).ToArray();
private System.Numerics.BigInteger Binomial(int n, int k) => System.Numerics.BigInteger.Divide(factorial[n], System.Numerics.BigInteger.Multiply(factorial[k], factorial[n - k]));
}
```
### 120. Triangle
Medium
```c#
public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) 
    {
        int[] result = new int[triangle.Count + 1];
        for (int i = triangle.Count - 1; i >= 0; i--)			
            for (int j = 0; j < triangle[i].Count; j++)				
                result[j] = Math.Min(result[j], result[j + 1]) + triangle[i][j];			
        return result[0];
    }
}
```
### 121. Best Time to Buy and Sell Stock
Easy
```c#
public class Solution {
    public int MaxProfit(int[] prices) {
        int maxCur = 0, maxSoFar = 0;
        for(int i = 1; i < prices.Length; i++) {
            maxCur = Math.Max(0, maxCur += prices[i] - prices[i-1]);
            maxSoFar = Math.Max(maxCur, maxSoFar);
        }
        return maxSoFar;
    }    
}
```
### 122. Best Time to Buy and Sell Stock II
Medium
```c#
public class Solution {
    public int MaxProfit(int[] prices) {
        int i = 0, buy, sell, profit = 0, N = prices.Length - 1;
        while (i < N) {
            while (i < N && prices[i + 1] <= prices[i]) i++;
            buy = prices[i];

            while (i < N && prices[i + 1] > prices[i]) i++;
            sell = prices[i];

            profit += sell - buy;
        }
        return profit;
    }
}
```
### 123. Best Time to Buy and Sell Stock III
Hard
```c#
using static System.Math;
public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = int.MinValue, sell = 0, buyAfter = int.MinValue, sellAfter = 0;
        foreach (int price in prices)
        {
            buy = Max(buy, -price);
            sell = Max(sell, buy + price);
            buyAfter = Max(buyAfter, sell - price);
            sellAfter = Max(sellAfter, buyAfter + price);
        }
        return sellAfter;
    }
}
```
### 124. Binary Tree Maximum Path Sum
Hard
```c#
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution 
{    
    public int MaxPathSum(TreeNode root) 
    {
        var max = int.MinValue;
        TrackBack(root, ref max);
        return max; 
    }
    public int TrackBack(TreeNode root, ref int max) 
    {		
        if (root == null) return 0; 		
        var (leftMax, rightMax) = (TrackBack(root.left, ref max), TrackBack(root.right, ref max));
        
        int result = Math.Max(root.val, (root.val + Math.Max(leftMax, rightMax)));
        max = Math.Max(max, Math.Max(result, leftMax + rightMax + root.val));
		
        return result;
    }
}
```
### 125. Valid Palindrome
Easy
```c#
public class Solution {
    public bool IsPalindrome(string s) =>
       (s = new string(s.ToLower().Where(char.IsLetterOrDigit).ToArray())).Equals(new string(s.Reverse().ToArray()), StringComparison.OrdinalIgnoreCase);    
}
```
