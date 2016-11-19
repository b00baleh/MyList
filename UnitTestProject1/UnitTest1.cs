using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            var list = l.ToList();
            Assert.AreEqual(3, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] {1, 2, 3}));
        }

        [TestMethod]
        public void TestDeleteFirstAndOne()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Delete(1);
            var list = l.ToList();
            Assert.AreEqual(0, list.Length);
        }

        [TestMethod]
        public void TestDeleteFirst()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Delete(1);
            var list = l.ToList();
            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] { 2, 3 }));
        }

        [TestMethod]
        public void TestDeleteLast()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Delete(3);
            var list = l.ToList();
            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] {1, 2}));
        }

        [TestMethod]
        public void TestDeleteMiddle()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Delete(2);
            var list = l.ToList();
            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] { 1, 3 }));
        }

        [TestMethod]
        public void TestReverse()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Reverse();
            var list = l.ToList();
            Assert.AreEqual(4, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] {4, 3, 2, 1 }));
        }

        [TestMethod]
        public void TestReverseOneElement()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Reverse();
            var list = l.ToList();
            Assert.AreEqual(1, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] {1 }));
        }

        [TestMethod]
        public void TestReverseTwoElement()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Add(2);
            l.Reverse();
            var list = l.ToList();
            Assert.AreEqual(2, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] { 2, 1 }));
        }

        [TestMethod]
        public void TestReverseThreeElements()
        {
            var l = new MyList.MyList<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Reverse();
            var list = l.ToList();
            Assert.AreEqual(3, list.Length);
            Assert.AreEqual(true, Eq(list, new int[] { 3, 2, 1 }));
        }

        [TestMethod]
        public static bool Eq(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }
            return true;
        }
    }
}
