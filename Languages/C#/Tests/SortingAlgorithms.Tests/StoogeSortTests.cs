using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class StoogeSortTests
    {
        [Test]
        public void TestStoogeSort()
        {
            int[] arrayToSort = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int[] expectedSortedArray = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            StoogeSort.Sort(arrayToSort, 0, arrayToSort.Length - 1);

            Assert.AreEqual(expectedSortedArray, arrayToSort);
        }
    }
}
