using NUnit.Framework;
using SearchingAlgorithms;

namespace SearchingAlgorithms.Tests
{
    [TestFixture]
    public class SentinelSearchTests
    {
        [Test]
        public void TestSentinelSearch()
        {
            int[] arrayToSearch = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };
            int targetElement = 11;
            int expectedIndex = 3;

            int actualIndex = SentinelSearch.Search(arrayToSearch, targetElement);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
