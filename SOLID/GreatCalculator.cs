using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class GreatCalculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimeters { get; private set; }

        public void Calculate(IEnumerable<IGeometricShape> shapes)
        {
            var areaOperations = new AreaOperations();
            var perimeterOperations = new PerimeterOperations();

            TotalAreas = areaOperations.Sum(shapes);
            TotalPerimeters = perimeterOperations.Sum(shapes);
        }
    }
}