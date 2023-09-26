using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class BucketSortTests
    {
        [Test]
        public void TestBucketSort()
        {
            int[] inputArray = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int[] expectedSortedArray = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            BucketSort.Sort(inputArray);

            Assert.AreEqual(expectedSortedArray, inputArray);
        }
    }
}
