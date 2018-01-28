using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Rectangle
    {
        private double slides = 4;
        public double Sides { 
            get { return this.slides; } 
        }
        public double Height { get; set; }
        public double Width { get; set; }

        public static double SumAreas(IEnumerable<Rectangle> rectangles)
        {
            double area = 0;
            foreach (var rectangle in rectangles)
                area += rectangle.Height * rectangle.Width;

            return area;
        }

        public static double SumParemeters(IEnumerable<Rectangle> rectangles)
        {
            double parameter = 0;
            foreach (var rectangle in rectangles)
                parameter += 2 * rectangle.Height + 2 * rectangle.Width;
            return parameter;
        }
    }
}
