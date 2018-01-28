using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class PerimeterOperations
    {
        public double Sum (IEnumerable<IGeometricShape> shapes)
        {
            double perimeter = 0;
            foreach (var shape in shapes)
                perimeter += shape.Perimeter();
               
            return perimeter;
        }
    }
}
