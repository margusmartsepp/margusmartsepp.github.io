using NUnit.Framework;
using SearchingAlgorithms;

namespace SearchingAlgorithms.Tests
{
    [TestFixture]
    public class ExponentialSearchTests
    {
        [Test]
        public void TestExponentialSearch()
        {
            int[] arrayToSearch = { 2, 3, 4, 10, 40 };
            int targetValue = 10;
            int expectedIndex = 3;

            int actualIndex = ExponentialSearch.Search(arrayToSearch, targetValue);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
