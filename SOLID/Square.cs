using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Square : IGeometricShape
    {
        private double slides = 4;
        public double Sides
        {
            get { return this.slides; }
        }
        public double SideLength { get; set; }
        public double Area()
        {
            return SideLength * SideLength;
        }

        public double Perimeter()
        {
            return SideLength * 4;
        }
    }
}
