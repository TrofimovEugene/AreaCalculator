using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace TestAreaCalculator
{
    [TestClass]
    public class TestAreaCalculator
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expected = 78.5398;
            var radius = 5.0;

            var areaCircle = new AreaCircle(radius);

            var actual = areaCircle.CalculateArea();
            
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var expected = 6.0;
            var a = 3.0;
            var b = 4.0;
            var c = 5.0;

            var areaTriangle = new AreaTriangle(a, b, c);

            var actual = areaTriangle.CalculateArea();
            
            Assert.AreEqual(expected, actual, 0.00001);
        }
    }
}