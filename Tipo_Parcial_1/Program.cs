using System;
using System.Collections.Generic;

namespace ejercio_parcial
{
    internal class Program
    {
        private enum MaterialTipo { Libro, AudioLibro, Revista }

        private class Material
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Anio { get; set; }
            public string Categoria { get; set; }
            public MaterialTipo Tipo { get; set; }
            public bool Prestado { get; set; }
            public DateTime FechaDevolucion { get; set; }
        }

        static void Main(string[] args)
        {
            var biblioteca = new List<Material>();

            // Datos de ejemplo
            biblioteca.Add(new Material { Id = 1, Titulo = "Don Quijote", Autor = "Miguel de Cervantes", Anio = 1605, Categoria = "Novela", Tipo = MaterialTipo.Libro, Prestado = false });
            biblioteca.Add(new Material { Id = 2, Titulo = "El Principito (Audiolibro)", Autor = "Antoine de Saint-Exupéry", Anio = 1943, Categoria = "Ficción", Tipo = MaterialTipo.AudioLibro, Prestado = false });
            biblioteca.Add(new Material { Id = 3, Titulo = "Revista Ciencia Hoy", Autor = "Varios", Anio = 2022, Categoria = "Ciencia", Tipo = MaterialTipo.Revista, Prestado = false });

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Bienvenido a la Biblioteca Digital");
                Console.WriteLine("1. Mostrar información de la biblioteca");
                Console.WriteLine("2. Mostrar audiolibros disponibles");
                Console.WriteLine("3. Mostrar libros disponibles");
                Console.WriteLine("4. Mostrar revistas disponibles");
                Console.WriteLine("5. Prestar un material");
                Console.WriteLine("6. Devolver un material");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción (1-7): ");

                string entrada = Console.ReadLine();
                int opcion;
                if (!int.TryParse(entrada, out opcion))
                {
                    Console.WriteLine("Entrada no válida. Intente de nuevo.");
                    continue;
                }

                if (opcion == 7) break;

                switch (opcion)
                {
                    case 1:
                        MostrarInformacionGeneral(biblioteca);
                        break;
                    case 2:
                        MostrarPorTipo(biblioteca, MaterialTipo.AudioLibro);
                        break;
                    case 3:
                        MostrarPorTipo(biblioteca, MaterialTipo.Libro);
                        break;
                    case 4:
                        MostrarPorTipo(biblioteca, MaterialTipo.Revista);
                        break;
                    case 5:
                        PrestarMaterial(biblioteca);
                        break;
                    case 6:
                        DevolverMaterial(biblioteca);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 7.");
                        break;
                }
            }

            Console.WriteLine("Gracias por usar la Biblioteca Digital. ¡Hasta luego!");
        }

        private static void MostrarInformacionGeneral(List<Material> biblioteca)
        {
            int libros = biblioteca.FindAll(m => m.Tipo == MaterialTipo.Libro).Count;
            int audiolibros = biblioteca.FindAll(m => m.Tipo == MaterialTipo.AudioLibro).Count;
            int revistas = biblioteca.FindAll(m => m.Tipo == MaterialTipo.Revista).Count;
            int prestados = biblioteca.FindAll(m => m.Prestado).Count;

            Console.WriteLine("Información de la Biblioteca Digital:");
            Console.WriteLine("Libros disponibles: " + libros);
            Console.WriteLine("Audiolibros disponibles: " + audiolibros);
            Console.WriteLine("Revistas disponibles: " + revistas);
            Console.WriteLine("Materiales prestados: " + prestados);
        }

        private static void MostrarPorTipo(List<Material> biblioteca, MaterialTipo tipo)
        {
            var lista = biblioteca.FindAll(m => m.Tipo == tipo && !m.Prestado);
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay elementos disponibles para el tipo seleccionado.");
                return;
            }

            Console.WriteLine();
            foreach (var m in lista)
            {
                Console.WriteLine("ID: {0} | Título: {1} | Autor: {2} | Año: {3} | Categoría: {4}", m.Id, m.Titulo, m.Autor, m.Anio, m.Categoria);
            }
        }

        private static void PrestarMaterial(List<Material> biblioteca)
        {
            Console.Write("Ingrese el ID del material a prestar: ");
            string s = Console.ReadLine();
            int id;
            if (!int.TryParse(s, out id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            var item = biblioteca.Find(m => m.Id == id);
            if (item == null)
            {
                Console.WriteLine("Material no encontrado.");
                return;
            }
            if (item.Prestado)
            {
                Console.WriteLine("El material ya se encuentra prestado.");
                return;
            }

            item.Prestado = true;
            item.FechaDevolucion = DateTime.Now.AddDays(14);
            Console.WriteLine("Material prestado correctamente. Fecha de devolución: {0}", item.FechaDevolucion.ToShortDateString());
        }

        private static void DevolverMaterial(List<Material> biblioteca)
        {
            Console.Write("Ingrese el ID del material a devolver: ");
            string s = Console.ReadLine();
            int id;
            if (!int.TryParse(s, out id))
            {
                Console.WriteLine("ID inválido.");
                return;
            }

            var item = biblioteca.Find(m => m.Id == id);
            if (item == null)
            {
                Console.WriteLine("Material no encontrado.");
                return;
            }
            if (!item.Prestado)
            {
                Console.WriteLine("El material no está prestado.");
                return;
            }

            DateTime hoy = DateTime.Now.Date;
            int diasRetraso = (hoy - item.FechaDevolucion.Date).Days;
            decimal multa = 0m;
            if (diasRetraso > 0)
            {
                multa = (decimal)diasRetraso * 1.5m; // 1.5 unidades monetarias por día
            }

            item.Prestado = false;
            item.FechaDevolucion = DateTime.MinValue;

            if (multa > 0)
            {
                Console.WriteLine("Material devuelto. Multa por {0} días de retraso: {1:C}", diasRetraso, multa);
            }
            else
            {
                Console.WriteLine("Material devuelto a tiempo. Gracias.");
            }
        }
    }
}
