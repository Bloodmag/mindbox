using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculationLibrary.Figures;

namespace AreaCalculationLibraryUnit
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //wrong parameter exception
            try
            {
                var c = new Circle(-1);
                Assert.Fail();
            }
            catch { }
            //prep
            var c1 = new Circle(1);
            var c2 = new Circle(5);
            //act
            var s1 = c1.GetArea();
            var p1 = c1.GetPerimeter();
            var s2 = c2.GetArea();
            var p2 = c2.GetPerimeter();
            //asserts
            Assert.AreEqual(s1, System.Math.PI);
            Assert.AreEqual(p1, System.Math.PI * 2);

            Assert.AreEqual(s2, 78.53981633974483);
            Assert.AreEqual(p2, 31.41592653589793);

            var d = 100;
            c2.Diameter = d;
            Assert.AreEqual(c2.Radius, d / 2);
        }
    }
}
