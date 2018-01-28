using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Rectangle : IGeometricShape
    {
        private double slides = 4;
        public double Sides { 
            get { return this.slides; } 
        }
        public virtual double Height { get; set; }
        public virtual double Width { get; set; }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return Height * 2 + Width * 2;
        }
    }
}
