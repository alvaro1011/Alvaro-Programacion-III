using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reto
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3;  i++)
            {
                Console.WriteLine("ingrese  su nombre  ");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrese su año de nacimiento  ");
                string fechanacimiento =Console.ReadLine();

               DateTime  fechausuario = DateTime.Parse(fechanacimiento);
               TimeSpan diaparacumpleaños = (  DateTime.Now - fechausuario );

                string data = ($"el amigo {nombre}, le hace falta {diaparacumpleaños.TotalDays} para su cumple años ");
                string rura = "cumpelaños.txt";

                File.WriteAllText(rura, data);



            }
        }
    }
}
