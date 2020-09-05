using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Linq;

namespace Codility
{
    public class MaxProductOfThree
    {

        public int solution(int[] A)
        {
            var a = A.ToList().Where(x=>x>=0).OrderByDescending(x => x);
            var b = A.ToList().Where(x=>x<0).OrderByDescending(x=>x);
            List<int> list2NegAnd1Positive = new List<int>();
            List<int> list3Positive = new List<int>();
            List<int> list3Negative = new List<int>();
            List<int> Maxes = new List<int>();
            if (a.Count() >= 3)
            {
                list3Positive = a.Take(3).ToList();
            }
            if (b.Count() >= 2)
            {
                list2NegAnd1Positive = b.Take(2).ToList();
                if (a.Count() >= 1)
                {
                    list2NegAnd1Positive.Add(a.First());
                }else
                {

                }
            }
            if (b.Count() >= 3)
            {
                list3Negative = b.Take(3).ToList();
            }
            
            if (list3Positive.Count >= 3)
                try
                {
                    Maxes.Add(list3Positive[0] * list3Positive[1] * list3Positive[2]);
                }catch(Exception)
                { }
            if (list2NegAnd1Positive.Count >= 3)
                try
                {
                    Maxes.Add(list2NegAnd1Positive[0] * list2NegAnd1Positive[1] * list2NegAnd1Positive[2]);
                }catch(Exception)
                { }
            if (list3Negative.Count >= 3)
                try
                {
                    Maxes.Add(list3Negative[0] * list3Negative[1] * list3Negative[2]);
                }
                catch (Exception)
                { }
            return Maxes.Max();

            

            
        }
    }

    public class Test
    {
        [TestCase(-120,-5, -6, -4, -7, -10)]
       [TestCase(125, -5, 5, -5, 4)]
        
        [TestCase(-80,-10, -2, -4)]
        [TestCase(60,
                   -3,
                   1,
                   2,
                   -2,
                   5,
                   6)]
        [TestCase(125,
                  -5, 5, -5, 4)]
        
        public void TestMaxProductOfThree(int expected, params int[]A)
        {
            var prob = new MaxProductOfThree();
            Assert.AreEqual(expected,prob.solution( A));

        }


    }
}
