using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class EquilateralTriangle : IGeometricShape
    {
        private double slides = 4;
        public double Sides
        {
            get { return this.slides; }
        }
        public double SideLength { get; set; }

        public double Area()
        {
            return Math.Sqrt(3) * Math.Pow(SideLength, 2) / 4;
        }

        public double Perimeter()
        {
            return SideLength * 3;
        }
    }
}
