using ProgIII.Ejercicios_Clase.Ejercicio1;
using ProgIII.Ejercicios_Clase.Ejercicio2;
using ProgIII.Ejercicios_Clase.Ejercicio3;
using ProgIII.Ejercicios_Clase.Ejercicio4;
using ProgIII.Ejercicios_Clase.Ejercicio5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgIII
{
        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("========== MENU EJERCICIOS ==========");
                Console.WriteLine("1. Mascota Virtual.");
                Console.WriteLine("2. Inventario de Tienda.");
                Console.WriteLine("3. App de Música.");
                Console.WriteLine("4. Sistema Biblioteca.");
                Console.WriteLine("5. Vehículos Eléctricos.");
                Console.Write("\nSeleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                if (opcion == 1)
                {
                    Mascota Mascotas = new Mascota();
                    Mascotas.MostrarMascotas();

                }
                else if (opcion == 2)
                {
                    Console.WriteLine("========== INVENTARIO DE TIENDA ==========");
                    Producto producto = new Producto("Camisa", 25000, 30);
                    Console.WriteLine("Producto: " + producto.Nombre + " | Precio: $ " + producto.Precio_Producto + " | Stock: " + producto.Cantidad_Stock);
                    Console.WriteLine("");
                    Console.Write("Ingrese cantidad a comprar: ");

                    producto.Cantidad = int.Parse(Console.ReadLine());
                    producto.VenderProducto();

                }
                else if (opcion == 3)
                {
                    // Creamos una lista de reproductores (pueden mezclarse canciones y podcasts)
                    List<IReproductor> biblioteca = new List<IReproductor>();

                    biblioteca.Add(new Cancion("Starboy", "The Weeknd"));
                    biblioteca.Add(new Podcast("IA en 5 minutos", "Tech Host"));

                    Console.WriteLine("=== MI BIBLIOTECA DE STREAMING ===");
                    for (int i = 0; i < biblioteca.Count; i++)
                    {
                        Console.WriteLine(i + ". " + biblioteca[i].GetType().Name);
                    }

                    Console.Write("\nSeleccione que desea reproducir: ");
                    int eleccion = int.Parse(Console.ReadLine());

                    if (eleccion >= 0 && eleccion < biblioteca.Count)
                    {
                        // No importa si es cancion o podcast, ambos tienen .Play()
                        biblioteca[eleccion].Play();
                    }
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("========== SISTEMA DE BIBLIOTECA ==========");
                    Libro miLibro = new Libro("Cien años de soledad");

                    string estadoInicial = miLibro.disponible ? "Disponible" : "Prestado";
                    Console.WriteLine("Libro: " + miLibro.titulo + " | Estado: " + estadoInicial);
                    Console.WriteLine("\nPresione Enter para intentar prestar el libro...");
                    Console.ReadLine();
                    miLibro.Prestar();
                    Console.WriteLine("\nIntentando prestar de nuevo el mismo libro:");
                    miLibro.Prestar();
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Vehículos Eléctricos - En desarrollo...");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }
}
