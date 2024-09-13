using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBoxTestLibrary.Figures
{
    public class Triangle : IFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsValidTriangle(sideA, sideB, sideC))
                throw new ArgumentException("It is not valid triangle!");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        }


        public bool IsRightTriangle()
        {
            double[] sides = { sideA, sideB, sideC };
            Array.Sort(sides);  // Сортируем стороны по возрастанию. Наибольшая сторона - гипотенуза


            double a = sides[0];
            double b = sides[1];
            double c = sides[2];

            return c * c == (a * a + b * b);
        }

        // Для вычисления площади треугольника используем формулу Герона
        public double GetArea()
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }
    }
}
