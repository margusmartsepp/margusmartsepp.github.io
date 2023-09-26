using NUnit.Framework;
using SearchingAlgorithms;

namespace SearchingAlgorithms.Tests
{
    [TestFixture]
    public class LinearSearchTests
    {
        [Test]
        public void TestLinearSearch()
        {
            int[] arrayToSearch = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int targetValue = 11;
            int expectedIndex = 3;

            int actualIndex = LinearSearch.Search(arrayToSearch, targetValue);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
