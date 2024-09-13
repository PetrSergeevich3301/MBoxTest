using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MBoxTestLibrary.Figures;

namespace MBoxTestLibrary.Tests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void TestCreateCircle()
        {
            double radius = 5;

            IFigure circle = new Circle(radius);

            Assert.IsNotNull(circle);
            
        }

        [TestMethod]
        public void TestCreateCircle_NotValidCircle()
        {
            double radius = -5;

            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));

        }

        [TestMethod]
        public void TestCalculateArea_Radius4()
        {
            double radius = 4;
            double exceptedArea = 50.26548245743669;

            IFigure circle = new Circle(radius);

            Assert.AreEqual(exceptedArea, circle.GetArea());
        }

        [TestMethod]
        public void TestCalculateArea_Radius43()
            {
            double radius = 43;
            double exceptedArea = 5808.8048164875272;

            IFigure circle = new Circle(radius);

            Assert.AreEqual(exceptedArea, circle.GetArea());
        }

    }
}
