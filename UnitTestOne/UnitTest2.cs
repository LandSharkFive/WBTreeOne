using WBTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestHeight1()
        {
            List<int> myList = new List<int>();
            myList.Add(83);
            myList.Add(551);
            myList.Add(868);
            myList.Add(546);
            myList.Add(366);
            myList.Add(744);
            myList.Add(191);
            myList.Add(922);
            myList.Add(767);
            myList.Add(111);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            Assert.AreEqual(5, a.Height());

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestHeight2()
        {
            List<int> myList = new List<int>();
            myList.Add(79);
            myList.Add(102);
            myList.Add(53);
            myList.Add(336);
            myList.Add(485);
            myList.Add(955);
            myList.Add(222);
            myList.Add(251);
            myList.Add(891);
            myList.Add(164);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            Assert.AreEqual(5, a.Height());

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestBuild1()
        {
            List<int> myList = new List<int>();
            myList.Add(5);
            myList.Add(79);
            myList.Add(102);
            myList.Add(164);
            myList.Add(222);
            myList.Add(251);
            myList.Add(336);
            myList.Add(485);
            myList.Add(891);
            myList.Add(955);
            
            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 9);

            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(3, a.Height());

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestBalance1()
        {
            List<int> myList = new List<int>();
            myList.Add(79);
            myList.Add(56);
            myList.Add(485);
            myList.Add(222);
            myList.Add(891);
            myList.Add(244);
            myList.Add(897);
            myList.Add(863);
            myList.Add(943);
            myList.Add(155);

            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(4, a.Height());

            a.Balance(a);
            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(3, a.Height());

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestGetList1()
        {
            List<int> myList = new List<int>();
            myList.Add(79);
            myList.Add(5);
            myList.Add(485);
            myList.Add(222);
            myList.Add(891);
            myList.Add(244);
            myList.Add(897);
            myList.Add(863);
            myList.Add(943);
            myList.Add(155);

            Tree a = new Tree();
            a.AddRange(myList);

            var b = a.GetList();

            Assert.AreEqual(a.Count(), myList.Count());
            Assert.AreEqual(b.Count(), myList.Count());
            Assert.AreEqual(a.Count(), b.Count());

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

    }
}
