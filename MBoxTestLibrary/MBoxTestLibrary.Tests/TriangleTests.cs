using MBoxTestLibrary;
using MBoxTestLibrary.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBoxTestLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestCreateTriangle()
        {
            double sideA = 3, sideB = 4, sideC = 5;
            IFigure triangle = new Triangle(sideA, sideB, sideC);
            Assert.IsNotNull(triangle);
        }

        [TestMethod]
        public void TestCreateTriangle_NotValid()
        {
            double sideA = 1, sideB = 4, sideC = 9;
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void TestIsRightTriangle_True()
        {
            //Египетский треугольник
            double sideA = 3, sideB = 4, sideC = 5;
            Triangle triangle = new Triangle(sideA,sideB, sideC);
            Assert.IsTrue(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TestIsRightTriangle_False()
        {
            double sideA = 3, sideB = 5, sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            Assert.IsFalse(triangle.IsRightTriangle());
        }

        [TestMethod]
        public void TestTriangleArea_3_4_5()
        {
            //Египетский треугольник
            double sideA = 3, sideB = 4, sideC = 5, exceptedArea = 6;
            IFigure triangle = new Triangle(sideA, sideB, sideC);

            Assert.IsTrue(triangle.GetArea() == exceptedArea);
        }

        [TestMethod]
        public void TestTriangleArea_3_5_5()
        {
            //Египетский треугольник
            double sideA = 3, sideB = 5, sideC = 5, exceptedArea = 7.1545440106270926;
            IFigure triangle = new Triangle(sideA, sideB, sideC);

            Assert.IsTrue(triangle.GetArea() == exceptedArea);
        }
    }
}
