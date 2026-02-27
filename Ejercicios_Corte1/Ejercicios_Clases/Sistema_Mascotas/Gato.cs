using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Corte1.Ejercicios_Clases.Sistema_Mascotas
{
    public class Gato : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine($"{Nombre} está amasando un pan.");
        }
    }
}