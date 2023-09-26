using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class InsertionSortTests
    {
        [Test]
        public void TestInsertionSort()
        {
            int[] arrayToSort = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int[] expectedSortedArray = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            InsertionSort.Sort(arrayToSort);

            Assert.AreEqual(expectedSortedArray, arrayToSort);
        }
    }
}
