using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculationLibrary.Figures;

namespace AreaCalculationLibraryUnit
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //wrong triangles' sides exceptions
            try
            {
                var tr = new Triangle(-1,1,1);
                Assert.Fail(); 
            }
            catch { }
            try
            {
                var tr = new Triangle(100, 1, 1);
                Assert.Fail(); 
            }
            catch { }


            //Arrange
            var t1 = new Triangle(2, 2, 2);
            var t2 = new Triangle(3, 4, 5);
            var t3 = new Triangle(1, 2, 3);
            var t4 = new Triangle(3, 6, 4);
            //Act
            var s1 = t1.GetArea();
            var p1 = t1.GetPerimeter();
            var s2 = t2.GetArea();
            var s3 = t3.GetArea();
            var p3 = t3.GetPerimeter();
            var s4 = t4.GetArea();
            //Asserts
            Assert.AreEqual(s1, 1.7320508075688772);
            Assert.AreEqual(p1, 6);
            Assert.AreEqual(t1.Alpha, 1.0471975511965979);
            Assert.AreEqual(t1.Beta, 1.0471975511965979);
            Assert.AreEqual(t1.Gamma, 1.0471975511965979);
            Assert.IsTrue(t1.IsEquilateral);
            Assert.IsFalse(t1.IsOrthogonal);

            Assert.AreEqual(s2, 6);
            Assert.IsFalse(t2.IsEquilateral);
            Assert.IsTrue(t2.IsOrthogonal);
            Assert.AreEqual(t2.Alpha, 0.6435011087932843);
            Assert.AreEqual(t2.Beta, 0.9272952180016123);
            Assert.AreEqual(t2.Gamma, 1.5707963267948966);

            Assert.AreEqual(s3, 0);
            Assert.AreEqual(p3, 6);
            Assert.IsFalse(t3.IsEquilateral);
            Assert.IsFalse(t3.IsOrthogonal);

            Assert.AreEqual(s4, 5.3326822519253856);
            Assert.IsFalse(t4.IsEquilateral);
            Assert.IsFalse(t4.IsOrthogonal);
        }
    }
}
