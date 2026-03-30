using System;
using System.IO;
using gestor_contactos.Models;

namespace gestor_contactos
{
    internal class Program
    {
        private static readonly string FilePath = "contactos.csv";

        static void Main(string[] args)
        {
            Console.WriteLine("Gestor de contactos");

            bool agregar = true;
            while (agregar)
            {
                Console.Write("Nombre: ");
                var nombre = Console.ReadLine();
                if (nombre != null)
                    nombre = nombre.Trim();
                else
                    nombre = string.Empty;

                Console.Write("Teléfono: ");
                var telefono = Console.ReadLine();
                if (telefono != null)
                    telefono = telefono.Trim();
                else
                    telefono = string.Empty;

                Console.Write("Correo: ");
                var correo = Console.ReadLine();
                if (correo != null)
                    correo = correo.Trim().ToLower();
                else
                    correo = string.Empty;

                
                Contacto contacto = new Contacto(nombre, telefono, correo);

                File.AppendAllText(FilePath, contacto.ToCSV() + Environment.NewLine);
                Console.WriteLine("Contacto guardado en '{0}'.", FilePath);

                Console.Write("¿Desea agregar otro contacto? (s/n): ");
                var resp = Console.ReadLine();
                if (resp == null)
                    agregar = false;
                else if (resp.Trim().ToLower() != "s")
                    agregar = false;
            }

            Console.Write("¿Listar contactos? (s/n): ");
            var listar = Console.ReadLine();
            if (listar != null && listar.Trim().ToLower() == "s")
            {
                if (!File.Exists(FilePath))
                {
                    Console.WriteLine("No hay contactos guardados.");
                }
                else
                {
                    var lines = File.ReadAllLines(FilePath);
                    Console.WriteLine();
                    foreach (var line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("Fin. Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
