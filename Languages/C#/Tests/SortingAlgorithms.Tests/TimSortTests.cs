using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class TimSortTests
    {
        [Test]
        public void TestTimSort()
        {
            int[] arrayToSort = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int[] expectedSortedArray = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            TimSort.Sort(arrayToSort, arrayToSort.Length);

            Assert.AreEqual(expectedSortedArray, arrayToSort);
        }
    }
}
