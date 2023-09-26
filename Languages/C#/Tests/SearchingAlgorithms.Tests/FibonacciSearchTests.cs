using NUnit.Framework;
using SearchingAlgorithms;

namespace SearchingAlgorithms.Tests
{
    [TestFixture]
    public class FibonacciSearchTests
    {
        [Test]
        public void TestFibonacciSearch()
        {
            int[] arrayToSearch = { 2, 3, 5, 7, 9, 10, 14, 15, 17, 19, 22, 24, 27, 30, 32 };
            int targetElement = 17;
            int expectedIndex = 8;

            int actualIndex = FibonacciSearch.Search(arrayToSearch, targetElement);

            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
