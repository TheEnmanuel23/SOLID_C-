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
            GreatCalculator calculator = new GreatCalculator();
            calculator.Calculate();

            Console.WriteLine("Suma de areas: " + calculator.TotalAreas);
            Console.WriteLine("Suma de perimetros: " + calculator.TotalPerimeters);
           
            Console.ReadKey();
        }
    }
}
