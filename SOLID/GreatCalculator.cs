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

        public void Calculate()
        {
            var figuras = new IGeometricShape[] {
                new Rectangle { Width = 10, Height = 5 },
                new EquilateralTriangle { SideLength = 10 },
                new Square { SideLength = 20 },
                new Rectangle { Width = 3, Height = 1 },
                new Square { SideLength = 32 }
            };

            var operacionesArea = new AreaOperations();
            var operacionesPerimetro = new PerimeterOperations();

            TotalAreas = operacionesArea.Sum(figuras);
            TotalPerimeters = operacionesPerimetro.Sum(figuras);
        }
    }
}
