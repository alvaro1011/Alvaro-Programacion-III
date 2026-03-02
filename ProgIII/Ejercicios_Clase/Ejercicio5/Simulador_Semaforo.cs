using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII.Ejercicios_Clase.Ejercicio5
{
    public class SemaforoInteligente
    {
        public string ColorActual;

       public SemaforoInteligente(string color)
        {
            ColorActual = color.ToLower();

        }

        public void MostrarAccion()
        {
            Console.WriteLine("");

            if (ColorActual == "verde")
            {
                Console.WriteLine("Accion: Sigue adelante");
            }
            else if (ColorActual == "amarillo")
            {
                Console.WriteLine("Accion: Preparate para frenar");
            }
            else if (ColorActual == "rojo")
            {
                Console.WriteLine("Accion: ¡Detente!");
            }
            else
            {
                Console.WriteLine("Color no reconocido. Intente de nuevo.");
            }
        }
    }
}
