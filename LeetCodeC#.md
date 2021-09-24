### 1. Two Sum
```c#
Easy
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