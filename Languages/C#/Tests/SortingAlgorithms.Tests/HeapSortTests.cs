using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class HeapSortTests
    {
        [Test]
        public void TestHeapSort()
        {
            int[] numbersToSort = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int[] expectedSortedNumbers = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            HeapSort.Sort(numbersToSort);

            Assert.AreEqual(expectedSortedNumbers, numbersToSort);
        }
    }
}
