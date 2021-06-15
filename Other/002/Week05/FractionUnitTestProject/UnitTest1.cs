using System;
using FractionLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Contructor_WithZeroArgument()
        {
            //arrange
            int expectedTop = 0, expectedBottom = 1;

            //act
            Fraction f = new Fraction();

            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }
        [TestMethod]
        public void Test_ToString()
        {
            int top = 4, bottom = 8;
            string expected = $"<{top}, {bottom}>";
            Fraction f = new Fraction(top, bottom);
            Assert.AreEqual(expected, f.ToString());
        }
        [TestMethod]
        public void Arithematic_Addtion()
        {
            int firstTop = 1, firstBottom = 2, secondTop = 3, secondBottom = 4;
            int expectedBottom = firstBottom * secondBottom;
            int expectedTop = firstTop * secondBottom + secondTop * firstBottom;
            Fraction f1 = new Fraction(firstTop, firstBottom);
            Fraction f2 = new Fraction(secondTop, secondBottom);
            Fraction f3 = f1 + f2;
            Assert.AreEqual(expectedTop, f3.Top);
            Assert.AreEqual(expectedBottom, f3.Bottom);
        }
    }
}
