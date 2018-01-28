using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class AreaOperations
    {
        public double Sum (IEnumerable<IGeometricShape> shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
                area += shape.Area();

            return area;
        } 
    }
}
