using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace Codility
{
    public class CodilityTest
    {
        private int[] ToIntArray(string str)
        {
            var arr = str.Split(',');
            List<int> lst = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                lst.Add(Convert.ToInt32(arr[i]));
            }

            return lst.ToArray();
        }
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(9, 2, "1001")]
        [TestCase(529, 4, "1000010001")]
        [TestCase(20, 1, "10100")]
        [TestCase(15, 0, "1111")]
        [TestCase(32, 0, "100000")]
        [Test]
        public void TestBinaryGap(int N, int expectedValue, string rep = null)
        {
            var bg = new BinaryGap();
            Assert.AreEqual(expectedValue, bg.solution(N));
        }

     

        [TestCase("3, 8, 9, 7, 6", 3, "9, 7, 6, 3, 8")]
        [TestCase("0,0,0",1, "0,0,0")]
        [TestCase("1, 2, 3, 4", 4, "1, 2, 3, 4")]
        [Test]
        public void TestCyclicRotation(string A, int K, string B)
        {
            var cr = new CyclicRotation();
            var a = ToIntArray(A);
            var b = ToIntArray(B);
            Assert.AreEqual(b, cr.solution(a, K));
        }

        [TestCase(7,  9, 3, 9, 3 , 9 ,  7, 9)]
        [Test]
        public void TestOddOccurrencesInArray(int expectedIndex, params int[] lst)
        {
            var odd = new OddOccurrencesInArray();
            Assert.AreEqual(expectedIndex, odd.solution(lst));

        }
    }
}