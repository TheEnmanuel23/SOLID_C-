using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
     
        static void Main(string[] args)
        {
            var figuras = new IGeometricShape[] {
                new Rectangle { Width = 10, Height = 5 },
                new EquilateralTriangle { SideLength = 10 },
                new Square { SideLength = 20 },
                new Rectangle { Width = 3, Height = 1 },
                new Square { SideLength = 32 }
            };

            GreatCalculator calculator = new GreatCalculator();
            calculator.Calculate(figuras);

            Console.WriteLine("Suma de areas: " + calculator.TotalAreas);
            Console.WriteLine("Suma de perimetros: " + calculator.TotalPerimeters);
           
            Console.ReadKey();
        }
    }
}
