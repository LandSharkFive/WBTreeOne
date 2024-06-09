using WBTreeOne;

namespace UnitTestOne
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestRemove1()
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
            a.Remove(892);
            a.Remove(382);

            Assert.AreEqual(8, a.Count());

            Assert.IsFalse(a.Search(892));
            Assert.IsFalse(a.Search(382));

            Assert.IsTrue(a.Search(288));
            Assert.IsTrue(a.Search(358));
            Assert.IsTrue(a.Search(772));
            Assert.IsTrue(a.Search(819));
            Assert.IsTrue(a.Search(557));
            Assert.IsTrue(a.Search(217));
            Assert.IsTrue(a.Search(963));
            Assert.IsTrue(a.Search(178));

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestRemove2()
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
            a.Remove(772);
            a.Remove(557);

            Assert.AreEqual(8, a.Count());

            Assert.IsFalse(a.Search(772));
            Assert.IsFalse(a.Search(557));

            Assert.IsTrue(a.Search(288));
            Assert.IsTrue(a.Search(358));
            Assert.IsTrue(a.Search(217));
            Assert.IsTrue(a.Search(819));
            Assert.IsTrue(a.Search(178));
            Assert.IsTrue(a.Search(892));
            Assert.IsTrue(a.Search(963));
            Assert.IsTrue(a.Search(382));

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }


        [TestMethod]
        public void TestRemove3()
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
            a.Remove(217);
            a.Remove(178);
            a.Remove(382);

            Assert.AreEqual(7, a.Count());

            Assert.IsFalse(a.Search(217));
            Assert.IsFalse(a.Search(178));
            Assert.IsFalse(a.Search(382));

            Assert.IsTrue(a.Search(288));
            Assert.IsTrue(a.Search(358));
            Assert.IsTrue(a.Search(772));
            Assert.IsTrue(a.Search(819));
            Assert.IsTrue(a.Search(557));
            Assert.IsTrue(a.Search(892));
            Assert.IsTrue(a.Search(963));

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestRemove4()
        {
            List<int> myList = new List<int>();
            myList.Add(33);
            myList.Add(34);
            myList.Add(61);
            myList.Add(70);
            myList.Add(280);
            myList.Add(419);
            myList.Add(420);
            myList.Add(441);
            myList.Add(442);
            myList.Add(558);
            myList.Add(570);
            myList.Add(590);
            myList.Add(604);
            myList.Add(623);
            myList.Add(624); 
            myList.Add(638);
            myList.Add(694);
            myList.Add(941);
            myList.Add(976);
            myList.Add(981);


            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 19);

            Assert.AreEqual(myList.Count, a.Count());

            a.Remove(280);
            a.Remove(288);
            a.Remove(441);
            a.Remove(442);
            a.Remove(624);
            a.Remove(981);

            Assert.AreEqual(15, a.Count());

            Assert.IsFalse(a.Search(280));
            Assert.IsFalse(a.Search(288));
            Assert.IsFalse(a.Search(441));
            Assert.IsFalse(a.Search(442));
            Assert.IsFalse(a.Search(624));
            Assert.IsFalse(a.Search(981));

            Assert.IsTrue(a.Search(33));
            Assert.IsTrue(a.Search(34));
            Assert.IsTrue(a.Search(61));
            Assert.IsTrue(a.Search(70));
            Assert.IsTrue(a.Search(419));
            Assert.IsTrue(a.Search(420));
            Assert.IsTrue(a.Search(570));
            Assert.IsTrue(a.Search(604));
            Assert.IsTrue(a.Search(638));
            Assert.IsTrue(a.Search(623));
            Assert.IsTrue(a.Search(638));
            Assert.IsTrue(a.Search(694));
            Assert.IsTrue(a.Search(941));
            Assert.IsTrue(a.Search(976));
            Assert.IsTrue(a.Search(638));

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }

        [TestMethod]
        public void TestRemove5()
        {
            List<int> myList = new List<int>();
            myList.Add(1);
            myList.Add(3);
            myList.Add(35);
            myList.Add(71);
            myList.Add(100);
            myList.Add(240);
            myList.Add(329);
            myList.Add(419);
            myList.Add(440);
            myList.Add(487);
            myList.Add(519);
            myList.Add(533);
            myList.Add(534);
            myList.Add(579);
            myList.Add(604);
            myList.Add(638);
            myList.Add(668);
            myList.Add(844);
            myList.Add(889);
            myList.Add(986);


            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 19);

            Assert.AreEqual(myList.Count, a.Count());
            Assert.AreEqual(20, a.Count());

            a.Remove(1);
            a.Remove(3);
            a.Remove(240);
            a.Remove(638);
            a.Remove(844);

            Assert.AreEqual(15, a.Count());

            Assert.IsFalse(a.Search(1));
            Assert.IsFalse(a.Search(3));
            Assert.IsFalse(a.Search(240));
            Assert.IsFalse(a.Search(411));
            Assert.IsFalse(a.Search(638));
            Assert.IsFalse(a.Search(884));

            Assert.IsTrue(a.Search(35));
            Assert.IsTrue(a.Search(71));
            Assert.IsTrue(a.Search(100));
            Assert.IsTrue(a.Search(329));
            Assert.IsTrue(a.Search(419));
            Assert.IsTrue(a.Search(440));
            Assert.IsTrue(a.Search(487));
            Assert.IsTrue(a.Search(533));
            Assert.IsTrue(a.Search(534));
            Assert.IsTrue(a.Search(579));
            Assert.IsTrue(a.Search(604));
            Assert.IsTrue(a.Search(889));
            Assert.IsTrue(a.Search(668));
            Assert.IsTrue(a.Search(889));
            Assert.IsTrue(a.Search(986));

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }


        [TestMethod]
        public void TestRemove6()
        {
            List<int> myList = new List<int>();
            myList.Add(15);
            myList.Add(39);
            myList.Add(85);
            myList.Add(418);
            myList.Add(528);
            myList.Add(844);
            myList.Add(902);
            myList.Add(959);
            myList.Add(962);
            myList.Add(988);

            // Add the list to a tree.
            Tree a = new Tree();
            a.Root = a.BuildTree(myList, 0, 9);

            Assert.AreEqual(myList.Count, a.Count());

            a.Remove(15);
            a.Remove(39);
            a.Remove(959);
            a.Remove(85);
            a.Remove(844);
            a.Remove(418);
            a.Remove(528);

            Assert.AreEqual(3, a.Count());

            Assert.IsFalse(a.Search(1));
            Assert.IsFalse(a.Search(2));
            Assert.IsFalse(a.Search(3));
            Assert.IsFalse(a.Search(15));
            Assert.IsFalse(a.Search(39));
            Assert.IsFalse(a.Search(85));
            Assert.IsFalse(a.Search(959));
            Assert.IsFalse(a.Search(844));
            Assert.IsFalse(a.Search(418));
            Assert.IsFalse(a.Search(528));

            Assert.IsTrue(a.Search(902));
            Assert.IsTrue(a.Search(962));
            Assert.IsTrue(a.Search(988));

            myList.Clear();
            a.Clear();
            Assert.IsNull(a.Root);
        }


    }
}
