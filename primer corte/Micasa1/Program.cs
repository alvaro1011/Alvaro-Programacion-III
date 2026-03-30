using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micasa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor de la vivienda: ");
            string valorv = Console.ReadLine();
            Console.WriteLine("ingrese la tasa de interes mensual: ");
            double tasa = double.Parse(Console.ReadLine());
            Console.WriteLine("plazos de meses: ");
            double meses = double.Parse(Console.ReadLine());


            double valorv1 = valorv * (0.5);


        }
    }
}
