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
            var rectangulos = new[] {
                new Rectangle { Width = 10, Height = 5 },
                new Rectangle { Width = 4, Height = 6 }
            };

            AreaOperations operacionesArea = new AreaOperations();
            PerimeterOperations operacionesPerimetro = new PerimeterOperations();

            var sumaAreas = operacionesArea.Sum(rectangulos);
            var sumaPerimetros = operacionesPerimetro.Sum(rectangulos);

            Console.WriteLine("Suma de areas: " + sumaAreas);
            Console.WriteLine("Suma de perimetros: " + sumaPerimetros);
            
            // Provando SIN el principio Liskov
            Rectangle cuadrado = new Square();
            cuadrado.Height = 12;
            Console.WriteLine(cuadrado.Area());

            Console.ReadKey();
        }
    }
}
