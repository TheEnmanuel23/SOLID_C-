using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class PerimeterOperations
    {
        public double Sum (IEnumerable<object> shapes)
        {
            double perimeter = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                    perimeter += 2 * ((Rectangle)shape).Height + 2 * ((Rectangle)shape).Width;
                else if (shape is EquilateralTriangle)
                    perimeter += ((EquilateralTriangle)shape).SideLength * 3;
            }
               
            return perimeter;
        }
    }
}
