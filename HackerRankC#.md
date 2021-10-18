# HackerRank - C#
## Practice > Algorithms > Warmup > 
### Solve Me First
Easy
```c#
using System;

namespace HackerRank
{
    public class SolveMeFirst
    {
        private readonly int _sum;

        private int GetSum(int a, int b)
        {
            return a + b;
        }

        public override string ToString()
        {
            return _sum.ToString();
        }

        public SolveMeFirst(int a, int b)
        {
            _sum = GetSum(a, b);
        }

        public static void Main()
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var sum = new SolveMeFirst(a, b);
            Console.WriteLine(sum);
        }
    }
}
```
### Simple Array Sum
Easy
```c#
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class SimpleArraySum
    {
        public static int GetSum(IEnumerable<int> numbers)
        {
            return numbers.Sum();
        }

        public static void Main()
        {
            // do not need to know number of elements
            Console.ReadLine(); 
            var numberLine = Console.ReadLine() ?? "";
            var numbersAsString = numberLine.Split(' ');
            var numbers = Array.ConvertAll(numbersAsString, int.Parse);
            var sum = GetSum(numbers);
            Console.WriteLine(sum);
        }
    }
}
```
### A Very Big Sum
Easy
```c#
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    class AVeryBigSum
    {
        public static long GetSum(IEnumerable<int> numbers)
        {
            return numbers.Aggregate(0L,(subSum, next) => subSum + next);
        }

        public static void Main()
        {
            // do not need to know number of elements
            Console.ReadLine();
            var numberLine = Console.ReadLine() ?? "";
            var numbersAsString = numberLine.Split(' ');
            var numbers = Array.ConvertAll(numbersAsString, int.Parse);
            var sum = GetSum(numbers);
            Console.WriteLine(sum);
        }
    }
}
```
### Diagonal Difference
Easy 
```c#
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    class DiagonalDifference
    {
        public static long GetSum(IEnumerable<int> numbers)
        {
            return numbers.Aggregate(0L, (subSum, next) => subSum + next);
        }

        public static IEnumerable<int> GetMainDiagonal(int[][] numbers)
        {
            return numbers.Select((t, i) => t[i]);
        }

        public static IEnumerable<int> GetSecondaryDiagonal(int[][] numbers)
        {
            var length = numbers.Length - 1;
            return numbers.Select((t, i) => numbers[length - i][i]);
        }

        public static long GetDiagonalDifference(int[][] numbers)
        {
            var mainDiagonal = GetMainDiagonal(numbers);
            var mainDiagonalSum = GetSum(mainDiagonal);
            var secondaryDiagonal = GetSecondaryDiagonal(numbers);
            var secondaryDiagonalSum = GetSum(secondaryDiagonal);
            var difference = Math.Abs(mainDiagonalSum - secondaryDiagonalSum);
            return difference;
        }

        public static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var a = new int[n][];
            for (var aI = 0; aI < n; aI++)
            {
                var aTemp = (Console.ReadLine() ?? "").Split(' ');
                a[aI] = Array.ConvertAll(aTemp, int.Parse);
            }
            var difference = GetDiagonalDifference(a);
            Console.WriteLine(difference);
        }
    }
}
```
### Diagonal Difference
Easy 
```c#
using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Algorithms.Warmup
{
    class PlusMinus
    {
        public static IEnumerable<decimal> GetCounts(int[] numbers)
        {
            yield return numbers.Count(o => o > 0); 
            yield return numbers.Count(o => o < 0);
            yield return numbers.Count(o => o == 0); 
        }

        public static IEnumerable<decimal> GetCountPrecentages(int n, int[] numbers)
        {
            return GetCounts(numbers).Select(count => decimal.Round(count / n, 6, MidpointRounding.AwayFromZero));
        }

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine() ?? "");
            var numberLine = Console.ReadLine() ?? "";
            var numbersAsString = numberLine.Split(' ');
            var numbers = Array.ConvertAll(numbersAsString, int.Parse);
            var counts = GetCountPrecentages(n,numbers);

            foreach (var count in counts)
            {
                Console.WriteLine(count);
            }
        }
    }
}
```
### Staircase
Easy 
```c#
using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Warmup
{
    class Staircase
    {
        public static IEnumerable<string> GetStaircase(int length)
        {
            for (var i = 1; i <= length; i++)
            {
                yield return new string(' ', length - i) + new string('#', i);
            }
        }

        public static void Main()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            foreach (var count in GetStaircase(n))
            {
                Console.WriteLine(count);
            }
        }
    }
}
```
### Time Conversion
Easy 
```c#
using System;

namespace HackerRank.Algorithms.Warmup
{
    class TimeConversion
    {
        public static string GeTime(string time)
        {
            var dateTime = DateTime.Parse(time);
            return dateTime.ToString("HH:mm:ss");
        }

        public static void Main()
        {
            var time = Console.ReadLine();
            Console.WriteLine(GeTime(time));
        }
    }
}
```
## Practice > Algorithms > Sorting
### Insertion Sort - Part 2
```c#
using System;
using System.Collections.Generic;

namespace HackerRank.Algorithms.Warmup
{
    class InsertionSort
    {
        public static IEnumerable<string> Sort<T>(T[] entries) where T : IComparable<T>
        {
            return Sort(entries, 0, entries.Length - 1);
        }

        public static IEnumerable<string> Sort<T>(T[] entries, int first, int last) where T : IComparable<T>
        {
            for (var i = first + 1; i <= last; i++)
            {
                var entry = entries[i];
                var j = i;

                while (j > first && entries[j - 1].CompareTo(entry) > 0)
                    entries[j] = entries[--j];

                entries[j] = entry;
                yield return string.Join(" ", entries);
            }
        }

        public static void Main()
        {
            Console.ReadLine();
            var splitElements = (Console.ReadLine() ?? "").Split(' ');
            var numbers = Array.ConvertAll(splitElements, int.Parse);

            foreach (var sortState in Sort(numbers))
            {
                Console.WriteLine(sortState);
            }
        }
    }
}
```
