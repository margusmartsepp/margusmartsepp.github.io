using NUnit.Framework;
using SearchingAlgorithms;
using System.Collections.Generic;

namespace SearchingAlgorithms.Tests
{
    [TestFixture]
    public class SublistSearchTests
    {
        [Test]
        public void TestIsSublist()
        {
            LinkedList<int> mainList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
            LinkedList<int> subList = new LinkedList<int>(new int[] { 3, 4 });
            bool isSublist = SublistSearch.IsSublist(mainList, subList);

            Assert.IsTrue(isSublist);
        }
    }
}
