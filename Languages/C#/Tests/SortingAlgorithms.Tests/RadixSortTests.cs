using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class RadixSortTests
    {
        [Test]
        public void TestRadixSort()
        {
            int[] inputArray = { 170, 45, 75, 90, 802, 24, 2, 66 };
            int[] expectedSortedArray = { 2, 24, 45, 66, 75, 90, 170, 802 };

            RadixSort.Sort(inputArray);

            Assert.AreEqual(expectedSortedArray, inputArray);
        }
    }
}
