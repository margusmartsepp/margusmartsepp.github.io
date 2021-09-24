## String
### Hamming distance
Hamming distance between two strings of equal length is the number of positions at which the corresponding symbols are different.
```java
public static int HammingDistance(char[] x, char[] y) {
	if (x.length != y.length)
		return -1;

	int result = 0;
	for (int i = 0; i < y.length; i++)
		if (x[i] == y[i])
			result++;
	return result;
}
```
### Levenshtein distance
Levenshtein distance between two strings is minimum number of operations needed to transform one string into the other, where an operation is an insertion, deletion, or substitution of a single character. 
```java
public static int LevenshteinDistance(char[] s1, char[] s2) {
	int s1p = s1.length, s2p = s2.length;
	int[][] num = new int[s1p + 1][s2p + 1];

	// fill arrays
	for (int i = 0; i <= s1p; i++)
		num[i][0] = i;

	for (int i = 0; i <= s2p; i++)
		num[0][i] = i;

	for (int i = 1; i <= s1p; i++)
		for (int j = 1; j <= s2p; j++)
			num[i][j] = Math.min(Math.min(num[i - 1][j] + 1,
					num[i][j - 1] + 1), num[i - 1][j - 1]
					+ (s1[i - 1] == s2[j - 1] ? 0 : 1));

	return num[s1p][s2p];
}
```
### Damerau-Levenshtein distance
Damerau-Levenshtein distance between two strings is minimum number of operations needed to transform one string into the other, where an operation is an insertion, deletion, or substitution of a single character or a transposition of two characters.
```java
public static int DamerauLevenshteinDistance(char[] s1, char[] s2) {
	int s1p = s1.length, s2p = s2.length;
	int[][] num = new int[s1p + 1][s2p + 1];

	// fill arrays
	for (int i = 0; i <= s1p; i++)
		num[i][0] = i;

	for (int i = 0; i <= s2p; i++)
		num[0][i] = i;

	for (int i = 1; i <= s1p; i++)
		for (int j = 1; j <= s2p; j++) {
			num[i][j] = Math.min(Math.min(num[i - 1][j] + 1,
					num[i][j - 1] + 1), num[i - 1][j - 1]
					+ (s1[i - 1] == s2[j - 1] ? 0 : 1));
			if (i > 1 && j > 1 && s1[i] == s2[j - 1] && s1[i - 1] == s2[j])
				num[i][j] = Math.min(num[i][j], num[i - 2][j - 2]
						+ (s1[i - 1] == s2[j - 1] ? 0 : 1));
		}
	return num[s1p][s2p];
}
```
### Diff
Sortest edit distance to change 1 string to another.
```java
public string diff(char[] s1, char[] s2) {
    int s1p = s1.length, s2p = s2.length;
    int[][] num = new int[s1p + 1][s2p + 1];

    // fill array
    for (int i = 1; i <= s1p; i++)
        for (int j = 1; j <= s2p; j++)
            num[i][j] = (s1[i - 1] == (s2[j - 1]) ? 1 + num[i - 1][j - 1]
                    : Math.max(num[i - 1][j], num[i][j - 1]));

    // trace
    ArrayList<Character> c2 = new ArrayList<Character>();
    ArrayList<Character> c3 = new ArrayList<Character>();
    int eq = 0, eqc = 0;

    while (s1p != 0 && s2p != 0) {
        if (s1[s1p - 1] == (s2[s2p - 1])) {
            s1p--;
            s2p--;
            eq++;
            c2.add(0, '=');
            c3.add(0, s1[s1p]);
        } else if (num[s1p][s2p - 1] >= num[s1p - 1][s2p]) {
            s2p--;
            c2.add(0, '+');
            c3.add(0, s2[s2p]);
        } else {
            eq++;
            s1p--;
            c2.add(0, '-');
            c3.add(0, s1[s1p]);
        }
    }

    while (s2p-- > 0) {
        c2.add(0, '+');
        c3.add(0, s2[s2p]);
    }
    while (eq++ < s1.length) {
        c2.add(0, '-');
        c3.add(eqc, s1[eqc++]);
    }

    StringBuilder sb = new StringBuilder();
    for (int i = 0; i < c2.size(); i++)
        sb.append(c2.get(i));
    sb.append('\n');

    for (int i = 0; i < c3.size(); i++)
        sb.append(c3.get(i));
    sb.append('\n');

    return sb.toString().toLowerCase();
}
```
## Sort 
### Bubblesort
Basic two-loop sort.
```java
static void pia_bubblesort(int[] array) {
	int n = array.length, i = 0;
	boolean swaped;
	do {
		swaped = false;
		for (int j = 1; j < n - i; ++j)
			if (u_cmp(array[j - 1], array[j])) {
				u_swap(array, j, j - 1);
				swaped = true;
			}

		i++;
	} while (swaped);
}
```
### Cocktailsort
Bi-directional Bubble sort
```java
static void pia_cocktailsort(int[] array) {
	int n = array.length, i = 0, j = 0;
	boolean swaped;
	do {
		i++;
		swaped = false;
		for (j = n - i; j > 1; --j)
			if (u_cmp(array[j - 1], array[j])) {
				u_swap(array, j, j - 1);
				swaped = true;
			}

		if (!swaped)
			break;

		for (j = i; j < n; ++j)
			if (u_cmp(array[j - 1], array[j])) {
				u_swap(array, j, j - 1);
				swaped = true;
			}

	} while (swaped);
}
```
### Combsort
Improved on bubble sort
```java
static void pia_combsort(int[] array) {
	int n, gap = n = array.length, i;
	boolean swapped = true;
	while (gap > 1 || swapped) {
		if (gap > 1)
			gap = (int) (gap / 1.3);

		i = 0;
		swapped = false;
		while (i + gap < n) {
			if (u_cmp(array[i], array[i + gap])) {
				u_swap(array, i, i + gap);
				swapped = true;
			}
			i++;
		}
	}
}
```
### Gnomesort
Bubble and Insertion sort combined.
```java
static void pia_gnomesort(int[] array) {
	int n = array.length;
	for (int i = 1; i < n;)
		if (i != 0 && u_cmp(array[i - 1], array[i])) {
			u_swap(array, i, i - 1);
			i--;
		} else
			i++;
}
```
### Heapsort
Two-stage comparison style sort.
```java
static void pia_heapsort(int[] array) {
	int n = array.length;
	PriorityQueue<Integer> heap = new PriorityQueue<Integer>(n);

	for (Integer elem : array)
		heap.add(elem);

	for (int i = 0; i < n; i++)
		array[i] = heap.remove();
}
```
### Insertionsort
Simple comparison sort.
```java
static void pia_insertionsort(int[] array) {
	int n = array.length, j, tmp;
	for (int i = 1; i < n; i++) {
		tmp = array[i];
		for (j = i; j > 0 && u_cmp(tmp, array[j - 1]); j--)
			array[j] = array[j - 1];
		array[j] = tmp;
	}
}
```
### Mergesort
A divide, sort, and merge algorithm.
```java
static void pia_mergesort(int[] array) {
	int left = 0, right = array.length - 1, i, j, k, l, m2, r2, m;
	if (right <= left)
		return;
	int[] tmp = new int[array.length];

	for (i = 1; i <= right - left; i = i + i)
		for (j = left; j <= right - i; j += i + i) {
			m2 = j + i - 1;
			r2 = Math.min(j + i + i - 1, right);

			for (k = m2 + 1; k > j; k--)
				tmp[k - 1] = array[k - 1];
			for (l = m2; l < r2; l++)
				tmp[r2 + m2 - l] = array[l + 1];
			for (m = j; m <= r2; m++)
				if (u_cmp(tmp[l], tmp[k]))
					array[m] = tmp[l--];
				else
					array[m] = tmp[k++];
		}
}
```
### Quicksort
Divide partition and sort.
```c#
static void pia_quicksort(int[] array) {
	int left = 0, right = array.length - 1, i, j;
	Stack<Integer> S = new Stack<Integer>();
	S.push(left);
	S.push(right);
	while (!S.empty()) {
		right = S.pop();
		left = S.pop();

		if (right <= left)
			continue;

		i = left - 1;
		j = right;
		while (true) {
			while (u_cmp(array[++i], array[right]))
				;
			while (u_cmp(array[right], array[--j]))
				if (j == left)
					break;

			if (i >= j)
				break;
			u_swap(array, i, j);
		}
		u_swap(array, i, right);

		if (i - left > right - i) {
			S.push(left);
			S.push(i - 1);
		}
		S.push(i + 1);
		S.push(right);
		if (right - i >= i - left) {
			S.push(left);
			S.push(i - 1);
		}
	}
}
```
### Selectionsort
In-place comparison sort
```java
static void pia_selectionsort(int[] array) {
	int min = 0, n = array.length;
	for (int i = 0; i < n; i++, min = i) {
		for (int j = i + 1; j < n; j++)
			if (u_cmp(array[j], array[min]))
				min = j;
		u_swap(array, i, min);
	}
}
```
### Shellsort
Improved insertion sort
```java
static void pia_shellsort(int[] array) {
	int n = array.length, j, tmp;
	for (int gap = n / 2; gap > 0; gap = (gap == 2 ? 1 : (int) (gap / 2.2)))
		for (int i = gap; i < n; i++) {
			tmp = array[i];
			for (j = i; j >= gap && u_cmp(tmp, array[j - gap]); j -= gap)
				array[j] = array[j - gap];
			array[j] = tmp;
		}
}
```
### Utils
Methods that sort algorithms call. 
```java
private static boolean u_cmp(int i, int j) {
	return i > j;
}

private static void u_swap(int[] a, int i, int j) {
	int swap = a[i];
	a[i] = a[j];
	a[j] = swap;
}
```
## Number theory
### Greatest common divisor
```java
public int gcd(int a, int b) {
    if (b != 0)
        return gcd(b, a % b);
    return Math.abs(a);
}
```
### Lowest common multiple
```java
public int lcm(int a, int b) {
    return (a * b) / gcd(a, b);
}
```
## Dynamic Programming
### Longest common subsequence
```java
/**
 * Bottom-up dynamic programming algorithm to find Longest Common
 * Subsequence of 2 input char arrays.
 *
 * Time = O(s1*s2) Space = O(s1*s2)
 */
public static char[] LCS(char[] s1, char[] s2) {
	int s1p = s1.length, s2p = s2.length;
	int[][] num = new int[s1p + 1][s2p + 1];

	// fill array
	for (int i = 1; i <= s1p; i++)
		for (int j = 1; j <= s2p; j++)
			if (s1[i - 1] == (s2[j - 1]))
				num[i][j] = 1 + num[i - 1][j - 1];
			else
				num[i][j] = Math.max(num[i - 1][j], num[i][j - 1]);

	// trace
	int counter = num[s1p][s2p];
	char[] result = new char[counter];

	while (s1p != 0 && s2p != 0) {
		if (s1[s1p - 1] == (s2[s2p - 1])) {
			result[--counter] = s1[s1p-- - 1];
		} else if (num[s1p][s2p - 1] < num[s1p - 1][s2p]) {
			s1p--;
			continue;
		}
		s2p--;
	}
	return result;
}
```
example usage:
```java
char[] seq1 = "abcbdab".toCharArray();
char[] seq2 = "bdcaba".toCharArray();
char[] out = LCS(seq1, seq2);

System.out.println("LSB len: " + out.length);
System.out.println("LSB seq: " + new String(out));
```
## Data structure
### Reverse Polish Notation
Used to turn ```52+(1+2)*4-3``` to ```52 1 2 + 4 * 3 - +``` and then calculate the value ```61```.
```java
public static String Infix2Postfix(String input) {
    if (input == null)
        return "";
    char[] in = input.toCharArray();
    Stack<Character> stack = new Stack<Character>();
    StringBuilder out = new StringBuilder();

    for (int i = 0; i < in.length; i++)
        switch (in[i]) {
        case '+':
        case '-':
                while (!stack.empty()
                                && (stack.peek() == '*' || stack.peek() == '/'))
                        out.append(' ').append(stack.pop());
        case '*':
        case '/':
                out.append(' ');
        case '(':
                stack.push(in[i]);
        case ' ':
                break;
        case ')':
                while (!stack.empty() && stack.peek() != '(')
                        out.append(' ').append(stack.pop());
                if (!stack.empty())
                        stack.pop();
                break;
        default:
                out.append(in[i]);
                break;
        }

    while (!stack.isEmpty())
        out.append(' ').append(stack.pop());

    return out.toString();
}
```
postfix
```java
static Integer Postfix(String in) {
	Stack<Integer> out = new Stack<Integer>();
	char[] a = in.toCharArray();
	int N = a.length;

	for (int i = 0; i < N; i++) {
		switch (a[i]) {
		case '/':
			if (out.size() >= 2)
				out.push(out.pop() + out.pop());
			break;
		case '+':
			if (out.size() >= 2)
				out.push(out.pop() + out.pop());
			break;
		case '*':
			if (out.size() >= 2)
				out.push((int) Math.floor(out.pop() * out.pop()));
			break;
		case '-':
			if (out.size() >= 2) {
				Integer t1 = out.pop();
				Integer t2 = out.pop();
				out.push(t2 - t1);
			} else {
				out.push(-out.pop());
			}

			break;
		}

		if ((a[i] >= '0') && (a[i] <= '9'))
			out.push(0);
		while (!out.isEmpty() && i < N && (a[i] >= '0') && (a[i] <= '9'))
			out.push(10 * out.pop() + (a[i++] - '0'));
	}
	if (out.size() == 1)
		return out.pop();
	return 0;
}
```