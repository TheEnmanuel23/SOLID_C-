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

            var sumaAreas = Rectangle.SumAreas(rectangulos);
            var sumaPerimetros = Rectangle.SumParemeters(rectangulos);

            Console.WriteLine("Suma de areas: " + sumaAreas);
            Console.WriteLine("Suma de perimetros: " + sumaPerimetros);

            Console.ReadKey();
        }
    }
}
