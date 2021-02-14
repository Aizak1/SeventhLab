using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Tests
{
    [TestClass()]
    public class Vector3Tests
    {
        [TestMethod()]
        public void LengthTest()
        {
            Vector3 vector = new Vector3(3, 0, 4);
            Assert.AreEqual(5, vector.Length());
        }
        [TestMethod()]
        public void ScalarCompositionTest()
        {
            Vector3 vector1 = new Vector3(3, 2, 2);
            Vector3 vector2 = new Vector3(2, 10, 2);
            Assert.AreEqual(30, Vector3.ScalarComposition(vector1, vector2));
        }
        [TestMethod]
        public void SumTest()
        {
            Vector3 vector1 = new Vector3(3, 4, 0);
            Vector3 vector2 = new Vector3(8, 0, 0);
            var result = new Vector3(11, 4, 0);
            var facts = vector1 + vector2;
            Assert.AreEqual(1, result.CompareTo(facts));
        }
        [TestMethod]
        public void MultiplierTest()
        {
            Vector3 vector1 = new Vector3(3, 4, 0);
            var result = new Vector3(6, 8, 0);
            var facts = vector1 * 2;
            Assert.AreEqual(1, result.CompareTo(facts));
        }
        [TestMethod]
        public void MultiplicationTest()
        {
            Vector3 vector1 = new Vector3(3, 4, 0);
            Vector3 vector2 = new Vector3(8, 0, 0);
            var result = new Vector3(0, 0, -32);
            var facts = vector1 * vector2;
            Assert.AreEqual(1, result.CompareTo(facts));
        }

        [TestMethod()]
        public void MixedCompositionTest()
        {
            Vector3 vector1 = new Vector3(-3,2,-1);
            Vector3 vector2 = new Vector3(1,0,2);
            Vector3 vector3 = new Vector3(4,5,-2);
            double result = Vector3.MixedComposition(vector1, vector2, vector3);
            var expected = 45;
            Assert.AreEqual(expected, result);
        }
    }
}