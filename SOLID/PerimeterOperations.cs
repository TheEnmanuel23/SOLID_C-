using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class PerimeterOperations
    {
        public double Sum (IEnumerable<Rectangle> rectangles)
        {
            double parameter = 0;
            foreach (var rectangle in rectangles)
                parameter += 2 * rectangle.Height + 2 * rectangle.Width;
            return parameter;
        }
    }
}
