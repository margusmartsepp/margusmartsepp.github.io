using NUnit.Framework;
using SortingAlgorithms;

namespace SortingAlgorithms.Tests
{
    [TestFixture]
    public class BeadSortTests
    {
        [Test]
        public void TestBeadSort()
        {
            int[] numbersToSort = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int[] expectedSortedNumbers = { 2, 3, 5, 6, 7, 9, 10, 11, 12, 14 };

            BeadSort.Sort(numbersToSort);

            Assert.AreEqual(expectedSortedNumbers, numbersToSort);
        }
    }
}
