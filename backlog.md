This contains issues I did not solve in 15min, but I want to continue solving other problems.

## Leet code
### 95. Unique Binary Search Trees II
Medium
```c#
Dictionary<int, List<List<int?>>> map = new Dictionary<int, List<List<int?>>> {
    { 0, new List<List<int?>> { new List<int?> { null } } },
    { 1, new List<List<int?>> { new List<int?> { 1, null, null } } }
};
public List<TreeNode> GenerateTrees(int n)
{
    if (!map.ContainsKey(n))
        for (int i = 2; i <= n; i++)
        {
            foreach (var k in map[i - 1])
            {
                var item = k.Select((o, x) => (x, o)).Where(o => o.o == null)
                    .Select(o => k.Take(o.x).Concat(new int?[] { i, null, null }).Concat(k.Skip(o.x + 1)).ToList()).ToList();
                map[i] = map.ContainsKey(i) ? map[i].Concat(item).ToList() : item;
            }
            // [1,3,2] and [1,2,3] are wrong duplicates. Valid BST is [2,1,3]
            // following line should find valid permutation and remove duplicates.
            map[i] = map[i].GroupBy(o => o.Select((x, i) => x > 0 ? 0 : 1 << i).Sum()).Select(o => o.FirstOrDefault()).ToList();
        }
    var l = map[n].Select(o => SortedArrayToBST(o.ToArray())).ToList();
    return map[n].Select(o => { var m = 0; return ToTreeNode(o, ref m, o.Count); }).Reverse().ToList();
}
public TreeNode ToTreeNode(List<int?> values, ref int i, int n)
{
    var v = values[i++].Value;
    var l = values[i] == null ? null : ToTreeNode(values, ref i, n);
    var r = values[++i] == null ? null : ToTreeNode(values, ref i, n);
    return new TreeNode(v, l, r);
}
```
Related simpler issue issue 
```c#
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
```