using WBTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestRemoveAll1()
        {
            List<int> myList = new List<int>();
            myList.Add(892);
            myList.Add(288);
            myList.Add(358);
            myList.Add(382);
            myList.Add(217);
            myList.Add(963);
            myList.Add(772);
            myList.Add(178);
            myList.Add(819);
            myList.Add(557);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

    }
}
