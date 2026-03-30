using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios_Clase.Ejercicio1
{
    public class Gato : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine($"{Nombre} está amasando un pan.");
        }
    }
}
