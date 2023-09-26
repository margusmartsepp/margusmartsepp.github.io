using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void TestMergeSort()
        {
            int[] numbersToSort = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int[] expectedSortedNumbers = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            MergeSort.Sort(numbersToSort, 0, numbersToSort.Length - 1);

            Assert.AreEqual(expectedSortedNumbers, numbersToSort);
        }
    }
}
