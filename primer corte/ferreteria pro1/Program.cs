using ferreteria_pro1.ferreteria;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria_pro1
{
    internal class Program
    {
        static string ruta = "Citas.csv";
        static void Main(string[] args)
        {
            int opcion = -1;
            // Agregamos un while para que el programa no se cierre tras una acción
            while (opcion != 0)
            {
                Console.WriteLine("\n===== Ferrerteria =====");
                Console.WriteLine("1. crear");
                Console.WriteLine("2. leer");
                Console.WriteLine("3. modificar");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

                switch (opcion)
                {
                    case 1: crear(); break;
                    case 2: listar(); break;
                    case 3: modificar(); break;
                    case 0: Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        static void crear()
        {
            Console.WriteLine("\n===== crear =====");
            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("ingrese el id:  ");
             double id = double.Parse(Console.ReadLine());

            Console.Write("tipo de herramienta: ");
            tipo_de_herramienta esp = (tipo_de_herramienta)Enum.Parse(typeof(tipo_de_herramienta), Console.ReadLine(), true);

            Console.Write("Costo: ");
            double costo = double.Parse(Console.ReadLine());

            
            string nuevaLinea = $"{id},{nombre},{esp},{costo}";
            File.AppendAllLines(ruta, new List<string> { nuevaLinea });

            Console.WriteLine("cargo exitosamente.");
        }

        static void listar()
        {
            Console.WriteLine("\n===== Registros en CSV =====");
            if (File.Exists(ruta))
            {
                foreach (var x in File.ReadAllLines(ruta)) Console.WriteLine(x);
            }
            else { Console.WriteLine("El archivo no existe aún."); }
        }

        static void modificar()
        {
            Console.WriteLine("\n===== Cambiar  =====");
            Console.Write("Ingrese el nombre : ");
            string nombrePaciente = Console.ReadLine();

            Console.Write("Ingrese el tipo herramienta : ");
            tipo_de_herramienta nuevaEsp = (tipo_de_herramienta)Enum.Parse(typeof(tipo_de_herramienta), Console.ReadLine(), true);

            if (!File.Exists(ruta)) return;

            string[] lineas = File.ReadAllLines(ruta);
            bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] datos = lineas[i].Split(',');

                
                if (datos[0].Trim().ToUpper() == nombrePaciente.Trim().ToUpper())
                {
                    datos[1] = nuevaEsp.ToString(); 
                    lineas[i] = string.Join(",", datos); 
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(ruta, lineas);
                Console.WriteLine("¡Datos  actualizados con éxito!");
            }
            else
            {
                Console.WriteLine("........");
            }
        }
    
    }
}
