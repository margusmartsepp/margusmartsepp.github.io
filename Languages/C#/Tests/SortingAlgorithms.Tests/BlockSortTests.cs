using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class BlockSortTests
    {
        [Test]
        public void TestBlockSort()
        {
            int[] arrayToSort = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int blockSize = 5;
            int[] expectedSortedArray = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            BlockSort.Sort(arrayToSort, blockSize);

            Assert.AreEqual(expectedSortedArray, arrayToSort);
        }
    }
}
