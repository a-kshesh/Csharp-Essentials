using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor_WithZeroArgument()
        {
            //arrange
            int expectedTop = 0;
            int expectedBottom = 1;

            //act
            Fraction f = new Fraction();

            //assert
            Assert.AreEqual(expectedTop, f.top);


        }

        [TestMethod]
        public void Constructor_WithOneArgument()
        {
            //arrange
            int expectedTop = 5;
           
            
            //act
            Fraction f = new Fraction(expectedTop);
            
            //assert
            Assert.AreEqual(expectedTop, f.top);
        }

        [TestMethod]
        public void Constructor_WithTwoArgument()
        {
            //arrange
            int expectedTop = 5;
            int expectedBottom = 1;

            //act
            Fraction f = new Fraction(expectedTop,expectedBottom);

            //assert
            Assert.AreEqual(expectedTop, f.top);
            Assert.AreEqual(expectedBottom, f.bottom);
        }

        [TestMethod]
        public void ToString()
        {
            int top = 12;
            int bottom = 24;

            string expecctedString = $"<{top}> <{bottom}>";

            Fraction f = new Fraction(top,bottom);

            Assert.AreEqual(expecctedString,f.ToString());
        }

        [TestMethod]
        public void Addition()
        {
            int firstTop = 3;
            int firstBottom = 2;
            int secondTop = 5;
            int secondBottom = 2;
            int expectedBottom = firstBottom * secondBottom;
            int expectedTop = (firstTop * secondBottom) + (secondTop * firstBottom);

            Fraction f1 = new Fraction(firstTop, firstBottom);
            Fraction f2 = new Fraction(secondTop, secondBottom);
            Fraction f3 = f1 + f2;

            Assert.AreEqual(expectedTop,f3.top);
            Assert.AreEqual(expectedBottom, f3.bottom);
            
        }

    }
}
