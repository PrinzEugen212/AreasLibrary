using System;
using NUnit.Framework;
using AreasLibrary;

namespace Tests
{
    class LibraryTests
    {
        [TestFixture]
        public class TestClass
        {
            [TestCase(3.0, 4.0, 5.0, 6.0)]
            [TestCase(4.0, 5.0, 6.0, 9.9)]
            [TestCase(10, 10, 10, 43.3)]
            [TestCase(2, 2, 3, 1.98)]
            [TestCase(5, 9, 8, 19.9)]
            public void TriangleAreaTest(double a, double b, double c, double result)
            {
                Triangle triangle = new Triangle(a, b, c);
                Assert.AreEqual(triangle.Area, result, 0.05);
            }

            [TestCase(5, 78.5)]
            [TestCase(10, 314.2)]
            [TestCase(7, 153.9)]
            [TestCase(7, 153.9)]
            [TestCase(1000, 3141592.7)]
            public void CircleAreaTest(double radius, double result)
            {
                Circle circle = new Circle(radius);
                Assert.AreEqual(circle.Area, result, 0.05);
            }
            [TestCase(3.0, 4.0, 5.0, true)]
            public void RectangularTriangleTest(double a, double b, double c, bool result)
            {
                Triangle triangle = new Triangle(a, b, c);
                Assert.AreEqual(triangle.CheckRectangular(), result);
            }
        }

    }
}
