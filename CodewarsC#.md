### Josephus Permutation
5 kyu
```c#
using System;
using System.Collections.Generic;
using System.Linq;
public class Josephus
{
    public static List<object> JosephusPermutation(List<object> items, int k)
    {
        var i = 0;
        var result = new List<object>();
        var queue = new Queue<object>();     
        foreach (var item in items) {
            queue.Enqueue(item);
        }
        while (queue.Any())
        {
            var current = queue.Dequeue();
            if (++i % k == 0)
            {
                result.Add(current);
            }
            else
            {
                queue.Enqueue(current);
            }   
        }
        return result;
    }
}
```
### Text align justify
4 kyu
```c#
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solution 
{
  public class Kata
  {
        public static int lenX;
        public static int lineLen;
        public static string WordScrambler(Match spaces) => spaces.Value + (lineLen++ < lenX ? " " : "");        
        public static string Justify(string str, int len)
        {
            if (string.IsNullOrEmpty(str)) 
              return "";            
            lenX = len;
            var words = str.Split(' ');
            var lines = new List<string>();   
            var lastLine = words.Aggregate("", (line, word) => {
                if (!string.IsNullOrEmpty(line))
                {
                    if (line.Length + word.Length + 1 <= len)
                        return line + ' ' + word;
                    lines.Add(line);
                }
                return word;
            });
            lines = lines.Select(line =>
            {
                if (line.IndexOf(' ') >= 0)
                    for (lineLen = line.Length; lineLen < len;)                    
                        line = Regex.Replace(line, "\\s+", new MatchEvaluator(WordScrambler), RegexOptions.IgnorePatternWhitespace);                  
                return line;
            }).ToList();
            lines.Add(lastLine);
            return string.Join("\n", lines);
        }
  }
}
```
### Ten-Pin Bowling
4 kyu
```c#
using System;

public static class Kata
{
    private static char[] rolls;
    private static bool IsSpare(char val) => val == '/';
    private static bool IsStrike(char val) => val == 'X';
    public static int GetValue(int c) => IsStrike(rolls[c]) ? 10 : IsSpare(rolls[c]) ? 10-int.Parse("" + rolls[c-1]) : int.Parse(""+ rolls[c]);
    public static int BowlingScore(string frames)
    {
        rolls = frames.Replace(" ", "").ToCharArray();
        int score = 0;
        int frameIndex = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (IsSpare(rolls[frameIndex + 1]))
            {
                score += 10 + GetValue(frameIndex + 2);
                frameIndex += 2;
            }
            else if (IsStrike(rolls[frameIndex]))
            {
                score += 10 + GetValue(frameIndex + 1) + GetValue(frameIndex + 2);
                frameIndex++;
            }
            else
            {
                score += GetValue(frameIndex) + GetValue(frameIndex + 1);
                frameIndex += 2;
            }
        }
        return score;
    }
}
```
### Counting Change Combinations
4 kyu
```c#
using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{        
  public static int CountCombinations(int amount, int[] coins) => CountCombinations(amount, coins, 0);
  public static int CountCombinations(int amount, int[] coins, int checkFromIndex) => (amount == 0) 
      ? 1 
      : (amount < 0 || coins.Length == checkFromIndex) 
          ? 0 
          : CountCombinations(amount - coins[checkFromIndex], coins, checkFromIndex) + CountCombinations(amount, coins, checkFromIndex + 1);
}
```
### Hamming Numbers
4 kyu
```c#
using System;
using System.Collections.Generic;
using System.Linq;
public class Hamming
{
  public static Dictionary<int, long> results;
  public static long HammingNr((int x, int y, int z) power) => (long)(Math.Pow(2, power.x) * Math.Pow(3, power.y) * Math.Pow(5, power.z));
  public static long hamming(int n)
  {
      if(results == null)
      {
          var test = new Dictionary<int, long>();
          long key;
          (int x, int y, int z) value;
          var list = new SortedList<long, (int x, int y, int z)>();
          list.Add(HammingNr((0, 0, 0)), (0, 0, 0));
          for (int i = 0; i < 5001; i++)
          {
              var c = list.Skip(i).First();
              if (!list.ContainsKey(key = HammingNr(value = (c.Value.x + 1, c.Value.y, c.Value.z))))
                  list.Add(key, value);
              if (!list.ContainsKey(key = HammingNr(value = (c.Value.x, c.Value.y + 1, c.Value.z))))
                  list.Add(key, value);
              if (!list.ContainsKey(key = HammingNr(value = (c.Value.x, c.Value.y, c.Value.z + 1))))
                  list.Add(key, value);
              test.Add(i, list.Skip(i).First().Key);
          }

          results = test;
      }

      return results[n-1];
  }
}
```
### Strip Comments 
4 kyu
```c#
using System.Linq;
using System.Text.RegularExpressions;
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        return string.Join("\n", text.Split("\n").Select(o=>{
          foreach(var symbol in commentSymbols){
            o = o.Split(symbol).First().TrimEnd();
          }
          return o;
        }));
    }
}
```
### Pick peaks
5 kyu
```c#
using System;
using System.Collections.Generic;
using System.Linq;
public class PickPeaks
{
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var result = new List<(int pos, int peaks)>();
            for (var i = 1; i + 1 < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    var j = 1;
                    while (arr[i] == arr[i + j++] && ((i + j) < arr.Length)) { }
                    if (i + j <= arr.Length && arr[i] > arr[i + j - 1])
                    {
                        result.Add((i, arr[i]));
                        i += j - 1;
                    }
                }
            }
            return new Dictionary<string, List<int>>(){
                {"pos", result.Select(o=>o.pos).ToList()},
                {"peaks", result.Select(o=>o.peaks).ToList()},
              };
        }
}
```
### Human readable duration format
4 kyu
```c#
using System.Collections.Generic;
public class HumanTimeFormat{
  public static string formatDuration(int seconds){
    if(seconds == 0)
    {
      return "now";
    }
    var list = new List<string>();
    var years = seconds / (60 * 60 * 24 * 365);
    if(years > 0)
    {
      seconds = seconds % (60 * 60 * 24 * 365);
      list.Add($"{years} {(years == 1 ? "year": "years")}" );
    }
    var days = seconds / (60 * 60 * 24);
    if(days > 0)
    {
      seconds = seconds % (60 * 60 * 24);
      list.Add($"{days} {(days == 1 ? "day": "days")}" );
    }
    var hours = seconds / (60 * 60);
    if(hours > 0)
    {
      seconds = seconds % (60 * 60);
      list.Add($"{hours} {(hours == 1 ? "hour": "hours")}" );
    }
    var mins = seconds / (60);
    if(mins > 0)
    {
      seconds = seconds % (60);
      list.Add($"{mins} {(mins == 1 ? "minute": "minutes")}" );
    }
    if(seconds > 0)
    {
      list.Add($"{seconds} {(seconds == 1 ? "second": "seconds")}" );
    }
    if(list.Count == 1)
    {
      return list[0];
    }
    if(list.Count == 2)
    {
      return $"{list[0]} and {list[1]}";
    }
    if(list.Count == 3)
    {
      return $"{list[0]}, {list[1]} and {list[2]}";
    }
    if(list.Count == 4)
    {
      return $"{list[0]}, {list[1]}, {list[2]} and {list[3]}";
    }
    if(list.Count == 5)
    {
      return $"{list[0]}, {list[1]}, {list[2]}, {list[3]} and {list[4]}";
    }
    return "";
  }
}
```
### Greed is Good
5 kyu
```c#
using System;
using System.Linq;

public static class Kata
{
  public static int Score(int[] dice) {
    var result = 0;
    var group = dice.GroupBy(o => o).ToDictionary(g => g.Key, g => g.Count());
    foreach(var (key, points, count) in new[] { (1, 1000, 3), (6, 600, 3), (5, 500, 3), (4, 400, 3), (3, 300, 3), (2, 200, 3), (1, 100, 1), (1, 100, 1), (5, 50, 1), (5, 50, 1) })
    {
        if (group.ContainsKey(key) && group[key] >= count)
        {
            result += points;
            group[key] = group[key] - count;
        }
    }
    return result;
  }
}
```
### Snail
4 kyu
```c#
using System.Collections.Generic;
public class SnailSolution
{
  public static int[] Snail(int[][] array)
  {

    int lenght = array.Length;
    if (lenght == 1 && array[0].Length == 0)
    {
      return new int[0];
    }
    var count = lenght * lenght;
    var i = 0;
    var result = new List<int>();
    for (var n = 0; n < (lenght + 1) / 2; n++)
    {
      var y = n;
      var x = n;
      for (; x < lenght - n && count > i; x++, i++)
      {
        result.Add(array[y][x]);
      }
      x--;
      y++;
      for (; y < lenght - n && count > i; y++, i++)
      {
        result.Add(array[y][x]);
      }
      x--;
      y--;
      for (; n <= x && count > i; x--, i++)
      {
        result.Add(array[y][x]);
      }
      x++;
      y--;
      for (; n + 1 <= y && count > i; y--, i++)
      {
        result.Add(array[y][x]);
      }
    }

    return result.ToArray();
  }
}
```
### Range Extraction
4 kyu
```c#
using System.Text;
using System;
public class RangeExtraction
{
  public static int SpanLength(int[] args, int i) => args.Length <= i+1 
    ? 0
    : args[i+1]==args[i]+1 
      ? SpanLength(args, i+1) + 1
      : 0;  
  public static string Extract(int[] args)
  {
    var result = new StringBuilder();
    for(var i = 0; i < args.Length; i++)
    {
        if(i>0){
            result.Append(",");
        }

      var span = SpanLength(args, i);
      Console.WriteLine(span);
      if(span >= 2){
        result.Append($"{args[i].ToString()}-{args[i+span].ToString()}");
        i+=span;
      }else
      {
        result.Append($"{args[i].ToString()}");
      }
    }
    return result.ToString();  //TODO
  }
}
```
### PaginationHelper
5 kyu
```c#
using System;
using System.Collections.Generic;

public class PagnationHelper<T>
{
  public PagnationHelper(IList<T> collection, int itemsPerPage)
  {
    _collection = collection;
    _itemsPerPage = itemsPerPage;
  }
  private IList<T> _collection {get;set;}
  private int _itemsPerPage {get;set;}
  public int ItemCount
  {
    get
    {
      return _collection.Count;
    }
  }

  public int PageCount
  {
    get
    {
      return 1+ItemCount/_itemsPerPage;
    }
  }

  public int PageItemCount(int pageIndex)
  {
    if(pageIndex >= PageCount || pageIndex < 0){
      return -1;
    }
    if(pageIndex < (PageCount -1)){
      return _itemsPerPage;
    }
    return ItemCount % _itemsPerPage;
  }

  public int PageIndex(int itemIndex)
  {
    if(0 > itemIndex || itemIndex >= ItemCount){
      return -1;
    }
    return itemIndex / _itemsPerPage;
  }
}
```
### RGB To Hex Conversion
5 kyu
```c#
using System;
public class Kata
{
  public static string Hex(int n) => Math.Min(Math.Max(n,0),255).ToString("X2");
  public static string Rgb(int r, int g, int b) 
  {
    return Hex(r)+Hex(g)+Hex(b);
  }
}
```
### Is this a triangle?
7 kyu
```c#
using System.Linq;
using System.Collections.Generic;
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
      var list = new List<int> {a, b, c};
      var max = list.Max();
      return list.Where(o=>o!=max).Sum() > max;
    }
}
```
### Split Strings
6 kyu
```c#
using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class SplitString
{
  public static string[] Solution(string str)
  {
    var result = new List<string>();
    for(int i = 0; i<str.Length; i+=2)
    {
        var item = "" + str[i].ToString() + (i+1 < str.Length ? str[i + 1].ToString() : "_");
        result.Add(item);
    }
    return result.ToArray();
  }
}
```
### Find the odd int
6 kyu
```c#
using System.Linq;
namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {
        return seq.GroupBy(o => o).Where(o=> o.Count()% 2==1).Select(o=>o.Key).FirstOrDefault();
    }       
  }
}
```
### Array.diff
6 kyu
```c#
using System.Collections;
using System.Linq;
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    var set = b.ToHashSet();
    return a.Where(o=>!set.Contains(o)).ToArray();
  }
}
```
### Who likes it?
6 kyu
```c#
using System;
using System.Linq;
public static class Kata
{
  public static string Likes(string[] name)
  {
      switch (name.Count())
      {
          case 0:
              return "no one likes this";
          case 1:
              return $"{name.First()} likes this";
          case 2:
              return $"{name.First()} and {name.Skip(1).First()} like this";
          case 3:
              return $"{name.First()}, {name.Skip(1).First()} and {name.Skip(2).First()} like this";
          default:
              return $"{name.First()}, {name.Skip(1).First()} and {(name.Count()-2)} others like this";          
      }
  }
}
```
### IQ Test
6 kyu
```c#

5 kyu
Josephus Permutation
C#:
using System;
using System.Collections.Generic;
using System.Linq;
public class Josephus
{
    public static List<object> JosephusPermutation(List<object> items, int k)
    {
        var i = 0;
        var result = new List<object>();
        var queue = new Queue<object>();     
        foreach (var item in items) {
            queue.Enqueue(item);
        }
        while (queue.Any())
        {
            var current = queue.Dequeue();
            if (++i % k == 0)
            {
                result.Add(current);
            }
            else
            {
                queue.Enqueue(current);
            }   
        }
        return result;
    }
}
9 months agoRefactorDiscuss
4 kyu
Text align justify
C#:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Solution 
{
  public class Kata
  {
        public static int lenX;
        public static int lineLen;
        public static string WordScrambler(Match spaces) => spaces.Value + (lineLen++ < lenX ? " " : "");        
        public static string Justify(string str, int len)
        {
            if (string.IsNullOrEmpty(str)) 
              return "";            
            lenX = len;
            var words = str.Split(' ');
            var lines = new List<string>();   
            var lastLine = words.Aggregate("", (line, word) => {
                if (!string.IsNullOrEmpty(line))
                {
                    if (line.Length + word.Length + 1 <= len)
                        return line + ' ' + word;
                    lines.Add(line);
                }
                return word;
            });
            lines = lines.Select(line =>
            {
                if (line.IndexOf(' ') >= 0)
                    for (lineLen = line.Length; lineLen < len;)                    
                        line = Regex.Replace(line, "\\s+", new MatchEvaluator(WordScrambler), RegexOptions.IgnorePatternWhitespace);                  
                return line;
            }).ToList();
            lines.Add(lastLine);
            return string.Join("\n", lines);
        }
  }
}
9 months agoRefactorDiscuss
4 kyu
Ten-Pin Bowling
C#:
using System;

public static class Kata
{
    private static char[] rolls;
    private static bool IsSpare(char val) => val == '/';
    private static bool IsStrike(char val) => val == 'X';
    public static int GetValue(int c) => IsStrike(rolls[c]) ? 10 : IsSpare(rolls[c]) ? 10-int.Parse("" + rolls[c-1]) : int.Parse(""+ rolls[c]);
    public static int BowlingScore(string frames)
    {
        rolls = frames.Replace(" ", "").ToCharArray();
        int score = 0;
        int frameIndex = 0;
        for (int frame = 0; frame < 10; frame++)
        {
            if (IsSpare(rolls[frameIndex + 1]))
            {
                score += 10 + GetValue(frameIndex + 2);
                frameIndex += 2;
            }
            else if (IsStrike(rolls[frameIndex]))
            {
                score += 10 + GetValue(frameIndex + 1) + GetValue(frameIndex + 2);
                frameIndex++;
            }
            else
            {
                score += GetValue(frameIndex) + GetValue(frameIndex + 1);
                frameIndex += 2;
            }
        }
        return score;
    }
}
9 months agoRefactorDiscuss
4 kyu
Counting Change Combinations
C#:
using System;
using System.Collections.Generic;
using System.Linq;
public static class Kata
{        
  public static int CountCombinations(int amount, int[] coins) => CountCombinations(amount, coins, 0);
  public static int CountCombinations(int amount, int[] coins, int checkFromIndex) => (amount == 0) 
      ? 1 
      : (amount < 0 || coins.Length == checkFromIndex) 
          ? 0 
          : CountCombinations(amount - coins[checkFromIndex], coins, checkFromIndex) + CountCombinations(amount, coins, checkFromIndex + 1);
}
9 months agoRefactorDiscuss
4 kyu
Hamming Numbers
C#:
using System;
using System.Collections.Generic;
using System.Linq;
public class Hamming
{
  public static Dictionary<int, long> results;
  public static long HammingNr((int x, int y, int z) power) => (long)(Math.Pow(2, power.x) * Math.Pow(3, power.y) * Math.Pow(5, power.z));
  public static long hamming(int n)
  {
      if(results == null)
      {
          var test = new Dictionary<int, long>();
          long key;
          (int x, int y, int z) value;
          var list = new SortedList<long, (int x, int y, int z)>();
          list.Add(HammingNr((0, 0, 0)), (0, 0, 0));
          for (int i = 0; i < 5001; i++)
          {
              var c = list.Skip(i).First();
              if (!list.ContainsKey(key = HammingNr(value = (c.Value.x + 1, c.Value.y, c.Value.z))))
                  list.Add(key, value);
              if (!list.ContainsKey(key = HammingNr(value = (c.Value.x, c.Value.y + 1, c.Value.z))))
                  list.Add(key, value);
              if (!list.ContainsKey(key = HammingNr(value = (c.Value.x, c.Value.y, c.Value.z + 1))))
                  list.Add(key, value);
              test.Add(i, list.Skip(i).First().Key);
          }

          results = test;
      }

      return results[n-1];
  }
}
9 months agoRefactorDiscuss
4 kyu
Strip Comments
C#:
using System.Linq;
using System.Text.RegularExpressions;
public class StripCommentsSolution
{
    public static string StripComments(string text, string[] commentSymbols)
    {
        return string.Join("\n", text.Split("\n").Select(o=>{
          foreach(var symbol in commentSymbols){
            o = o.Split(symbol).First().TrimEnd();
          }
          return o;
        }));
    }
}
9 months agoRefactorDiscuss
5 kyu
Pick peaks
C#:
using System;
using System.Collections.Generic;
using System.Linq;
public class PickPeaks
{
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var result = new List<(int pos, int peaks)>();
            for (var i = 1; i + 1 < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    var j = 1;
                    while (arr[i] == arr[i + j++] && ((i + j) < arr.Length)) { }
                    if (i + j <= arr.Length && arr[i] > arr[i + j - 1])
                    {
                        result.Add((i, arr[i]));
                        i += j - 1;
                    }
                }
            }
            return new Dictionary<string, List<int>>(){
                {"pos", result.Select(o=>o.pos).ToList()},
                {"peaks", result.Select(o=>o.peaks).ToList()},
              };
        }
}
9 months agoRefactorDiscuss
4 kyu
Human readable duration format
C#:
using System.Collections.Generic;
public class HumanTimeFormat{
  public static string formatDuration(int seconds){
    if(seconds == 0)
    {
      return "now";
    }
    var list = new List<string>();
    var years = seconds / (60 * 60 * 24 * 365);
    if(years > 0)
    {
      seconds = seconds % (60 * 60 * 24 * 365);
      list.Add($"{years} {(years == 1 ? "year": "years")}" );
    }
    var days = seconds / (60 * 60 * 24);
    if(days > 0)
    {
      seconds = seconds % (60 * 60 * 24);
      list.Add($"{days} {(days == 1 ? "day": "days")}" );
    }
    var hours = seconds / (60 * 60);
    if(hours > 0)
    {
      seconds = seconds % (60 * 60);
      list.Add($"{hours} {(hours == 1 ? "hour": "hours")}" );
    }
    var mins = seconds / (60);
    if(mins > 0)
    {
      seconds = seconds % (60);
      list.Add($"{mins} {(mins == 1 ? "minute": "minutes")}" );
    }
    if(seconds > 0)
    {
      list.Add($"{seconds} {(seconds == 1 ? "second": "seconds")}" );
    }
    if(list.Count == 1)
    {
      return list[0];
    }
    if(list.Count == 2)
    {
      return $"{list[0]} and {list[1]}";
    }
    if(list.Count == 3)
    {
      return $"{list[0]}, {list[1]} and {list[2]}";
    }
    if(list.Count == 4)
    {
      return $"{list[0]}, {list[1]}, {list[2]} and {list[3]}";
    }
    if(list.Count == 5)
    {
      return $"{list[0]}, {list[1]}, {list[2]}, {list[3]} and {list[4]}";
    }
    return "";
  }
}
9 months agoRefactorDiscuss
5 kyu
Greed is Good
C#:
using System;
using System.Linq;

public static class Kata
{
  public static int Score(int[] dice) {
    var result = 0;
    var group = dice.GroupBy(o => o).ToDictionary(g => g.Key, g => g.Count());
    foreach(var (key, points, count) in new[] { (1, 1000, 3), (6, 600, 3), (5, 500, 3), (4, 400, 3), (3, 300, 3), (2, 200, 3), (1, 100, 1), (1, 100, 1), (5, 50, 1), (5, 50, 1) })
    {
        if (group.ContainsKey(key) && group[key] >= count)
        {
            result += points;
            group[key] = group[key] - count;
        }
    }
    return result;
  }
}
9 months agoRefactorDiscuss
4 kyu
Snail
C#:
using System.Collections.Generic;
public class SnailSolution
{
  public static int[] Snail(int[][] array)
  {

    int lenght = array.Length;
    if (lenght == 1 && array[0].Length == 0)
    {
      return new int[0];
    }
    var count = lenght * lenght;
    var i = 0;
    var result = new List<int>();
    for (var n = 0; n < (lenght + 1) / 2; n++)
    {
      var y = n;
      var x = n;
      for (; x < lenght - n && count > i; x++, i++)
      {
        result.Add(array[y][x]);
      }
      x--;
      y++;
      for (; y < lenght - n && count > i; y++, i++)
      {
        result.Add(array[y][x]);
      }
      x--;
      y--;
      for (; n <= x && count > i; x--, i++)
      {
        result.Add(array[y][x]);
      }
      x++;
      y--;
      for (; n + 1 <= y && count > i; y--, i++)
      {
        result.Add(array[y][x]);
      }
    }

    return result.ToArray();
  }
}
9 months agoRefactorDiscuss
4 kyu
Range Extraction
C#:
using System.Text;
using System;
public class RangeExtraction
{
  public static int SpanLength(int[] args, int i) => args.Length <= i+1 
    ? 0
    : args[i+1]==args[i]+1 
      ? SpanLength(args, i+1) + 1
      : 0;  
  public static string Extract(int[] args)
  {
    var result = new StringBuilder();
    for(var i = 0; i < args.Length; i++)
    {
        if(i>0){
            result.Append(",");
        }

      var span = SpanLength(args, i);
      Console.WriteLine(span);
      if(span >= 2){
        result.Append($"{args[i].ToString()}-{args[i+span].ToString()}");
        i+=span;
      }else
      {
        result.Append($"{args[i].ToString()}");
      }
    }
    return result.ToString();  //TODO
  }
}
9 months agoRefactorDiscuss
5 kyu
PaginationHelper
C#:
using System;
using System.Collections.Generic;

public class PagnationHelper<T>
{
  // TODO: Complete this class
  
  /// <summary>
  /// Constructor, takes in a list of items and the number of items that fit within a single page
  /// </summary>
  /// <param name="collection">A list of items</param>
  /// <param name="itemsPerPage">The number of items that fit within a single page</param>
  public PagnationHelper(IList<T> collection, int itemsPerPage)
  {
    _collection = collection;
    _itemsPerPage = itemsPerPage;
  }
private IList<T> _collection {get;set;}
private int _itemsPerPage {get;set;}
  /// <summary>
  /// The number of items within the collection
  /// </summary>
  public int ItemCount
  {
    get
    {
      return _collection.Count;
    }
  }

  /// <summary>
  /// The number of pages
  /// </summary>
  public int PageCount
  {
    get
    {
      return 1+ItemCount/_itemsPerPage;
    }
  }

  /// <summary>
  /// Returns the number of items in the page at the given page index 
  /// </summary>
  /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
  /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
  public int PageItemCount(int pageIndex)
  {
    if(pageIndex >= PageCount || pageIndex < 0){
      return -1;
    }
    if(pageIndex < (PageCount -1)){
      return _itemsPerPage;
    }
    return ItemCount % _itemsPerPage;
  }

  /// <summary>
  /// Returns the page index of the page containing the item at the given item index.
  /// </summary>
  /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
  /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
  public int PageIndex(int itemIndex)
  {
    if(0 > itemIndex || itemIndex >= ItemCount){
      return -1;
    }
    return itemIndex / _itemsPerPage;
  }
}
9 months agoRefactorDiscuss
5 kyu
RGB To Hex Conversion
C#:
using System;
public class Kata
{
  public static string Hex(int n) => Math.Min(Math.Max(n,0),255).ToString("X2");
  public static string Rgb(int r, int g, int b) 
  {
    return Hex(r)+Hex(g)+Hex(b);
  }
}
9 months agoRefactorDiscuss
7 kyu
Is this a triangle?
C#:
using System.Linq;
using System.Collections.Generic;
public class Triangle
{
    public static bool IsTriangle(int a, int b, int c)
    {
      var list = new List<int> {a, b, c};
      var max = list.Max();
      return list.Where(o=>o!=max).Sum() > max;
    }
}
9 months agoRefactorDiscuss
6 kyu
Split Strings
C#:
using System.Collections.Generic;
using System.Collections;
using System.Linq;
public class SplitString
{
  public static string[] Solution(string str)
  {
    var result = new List<string>();
    for(int i = 0; i<str.Length; i+=2)
    {
        var item = "" + str[i].ToString() + (i+1 < str.Length ? str[i + 1].ToString() : "_");
        result.Add(item);
    }
    return result.ToArray();
  }
}
9 months agoRefactor
6 kyu
Find the odd int
C#:
using System.Linq;
namespace Solution
{
  class Kata
  {
    public static int find_it(int[] seq) 
    {
        return seq.GroupBy(o => o).Where(o=> o.Count()% 2==1).Select(o=>o.Key).FirstOrDefault();
    }       
  }
}
9 months agoRefactor
6 kyu
Array.diff
C#:
using System.Collections;
using System.Linq;
public class Kata
{
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    var set = b.ToHashSet();
    return a.Where(o=>!set.Contains(o)).ToArray();
  }
}
9 months agoRefactor
6 kyu
Who likes it?
C#:
using System;
using System.Linq;
public static class Kata
{
  public static string Likes(string[] name)
  {
      switch (name.Count())
      {
          case 0:
              return "no one likes this";
          case 1:
              return $"{name.First()} likes this";
          case 2:
              return $"{name.First()} and {name.Skip(1).First()} like this";
          case 3:
              return $"{name.First()}, {name.Skip(1).First()} and {name.Skip(2).First()} like this";
          default:
              return $"{name.First()}, {name.Skip(1).First()} and {(name.Count()-2)} others like this";          
      }
  }
}
9 months agoRefactor
6 kyu
IQ Test
C#:
using System;
using System.Linq;

public class IQ
    {
        public static int Test(string numbers)
        { 
          var list = numbers.Split(" ")
              .Select((o, i)=>new {id = i, value = int.Parse(o)})
              .ToList();
          var odd = list.Count(o=>o.value%2!=0);
          var even = list.Count(o=>o.value%2==0);
          return (odd > even 
              ? list.FirstOrDefault(o => o.value%2==0).id 
              : list.FirstOrDefault(o => o.value%2!=0).id)+1;
        }
    }
```
### Delete occurrences of an element if it occurs more than n times
6 kyu
```c#
using System;
using System.Collections.Generic;
using System.Linq;

public class Kata {
  public static int[] DeleteNth(int[] arr, int x) {
    var dict = arr.Distinct().ToDictionary(o=>o, o=>0);
    var result = new List<int>();
    return arr.Select((o,i)=>new {id=i, value=o, count = ++dict[o]})
        .Where(o=>o.count<=x)
        .Select(o=>o.value)
        .ToArray();
  }
}
```
### Sum of odd numbers
7 kyu
```c#
using System;
public static class Kata
{
  public static long rowSumOddNumbers(long n)
  {
    return (1-n+n*n)*n+(n-1)*n;
  }
}
```
### Exes and Ohs
7 kyu
```c#
using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input)
  {    
    var group = input.ToLower().ToArray().GroupBy(o => o).ToDictionary(o=>o.Key, o=>o.Count());
    return group.ContainsKey('x') && group.ContainsKey('o') ? group['x']==group['o'] : !group.ContainsKey('x') && !group.ContainsKey('o');
  }
}
```
### Multiply
8 kyu
```c#
public class CustomMath {
    public static int multiply(int a, int b) {
        return a*b;
    }
}
```