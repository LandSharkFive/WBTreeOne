using WBTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            List<int> myList = new List<int>();
            myList.Add(8920);
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
            for (int i = 0; i < myList.Count; i++)
            {
                int value = myList[i];
                Assert.IsTrue(a.Search(value));
            }

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestAdd2()
        {
            List<int> myList = new List<int>();
            myList.Add(656);
            myList.Add(968);
            myList.Add(320);
            myList.Add(413);
            myList.Add(244);
            myList.Add(495);
            myList.Add(133);
            myList.Add(806);
            myList.Add(136);
            myList.Add(364);

            // Add the list to a tree.
            Tree a = new Tree();
            a.AddRange(myList);

            Assert.AreEqual(myList.Count, a.Count());
            for (int i = 0; i < myList.Count; i++)
            {
                int value = myList[i];
                Assert.IsTrue(a.Search(value));
            }

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestAdd3()
        {
            List<int> myList = new List<int>();
            myList.Add(83);
            myList.Add(551);
            myList.Add(858);
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
            for (int i = 0; i < myList.Count; i++)
            {
                int value = myList[i];
                Assert.IsTrue(a.Search(value));
            }

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestSearch1()
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
            for (int i = 0; i < myList.Count; i++)
            {
                int value = myList[i];
                Assert.IsNotNull(a.Search(value));
            }

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestGetValue1()
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
            for (int i = 0; i < myList.Count; i++)
            {
                int value = myList[i];
                Assert.IsTrue(a.Search(value));
            }

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

    }
}