using NUnit.Framework;
using SearchingAlgorithms;

namespace SearchingAlgorithms.Tests
{
    [TestFixture]
    public class BinarySearchTests
    {
        [Test]
        public void TestBinarySearch()
        {
            int[] sortedArray = { 2, 3, 5, 7, 9, 10, 11, 12, 14 };
            int targetValue = 10;
            int expectedIndex = 5;

            int actualIndex = BinarySearch.Search(sortedArray, targetValue);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
