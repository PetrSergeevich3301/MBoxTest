using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MBoxTestLibrary.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (!IsValidRadius(radius))
            {
                throw new ArgumentException("Radius must be greater than 0!");
            }
            Radius = radius;
        }

        private bool IsValidRadius(double radius)
        {
            return radius > 0;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
