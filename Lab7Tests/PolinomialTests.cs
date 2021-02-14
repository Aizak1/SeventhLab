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
    public class PolinomialTests
    {
        [TestMethod()]
        public void DivisionTest()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 1, -3 , 5 , -15 });
            Polinomial polinomial2 = new Polinomial(new double[] { 1, 0, 5 });

            Polinomial expected = new Polinomial(new double[] { 1,-3 });
            Polinomial actual = (polinomial1 / polinomial2).Item1;

            Assert.AreEqual(1, actual.CompareTo(expected));
        }
        [TestMethod]
        public void SumTest()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 6, 3, 0, 1, 7, 9 });
            Polinomial polinomial2 = new Polinomial(new double[] { 1, 2, 5, -3, -3, -29 });

            Polinomial expected = new Polinomial(new double[] { 7, 5, 5, -2, 4, -20 });
            Polinomial actual = polinomial1 + polinomial2;

            Assert.AreEqual(1, actual.CompareTo(expected));
        }
        [TestMethod]
        public void SubtractionTest()
        {
            Polinomial polinomial1 = new Polinomial(new double[] { 3, 2, 1, 4, 2, 5 });
            Polinomial polinomial2 = new Polinomial(new double[] { 1, 0, 5, -3, -3, -29 });

            Polinomial expected = new Polinomial(new double[] { 2, 2, -4, 7, 5, 34 });
            Polinomial actual = polinomial1 - polinomial2;

            Assert.AreEqual(1, actual.CompareTo(expected));
        }
        [TestMethod()]
        public void NumberMultiplicationTest()
        {
            double multiplier = 2;
            Polinomial polinomial1 = new Polinomial(new double[] { 3, 2, 1, 4, 2, 5 });
            

            Polinomial expected = new Polinomial(new double[] { 6, 4, 2, 8, 4, 10 });
            Polinomial actual = polinomial1 * multiplier;

            Assert.AreEqual(1, actual.CompareTo(expected));
        }
    }
}