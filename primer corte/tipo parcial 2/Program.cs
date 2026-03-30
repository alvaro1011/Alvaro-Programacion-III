using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipo_parcial_2.ConcesionarioVehiculos.enums;
using tipo_parcial_2.ConcesionarioVehiculos.Interfaces;
using tipo_parcial_2.ConcesionarioVehiculos.modelos;

namespace tipo_parcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVendible> ventas = new List<IVendible>();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("======= MENÚ CONCESIONARIO =======");
                Console.WriteLine("1. Registrar Auto");
                Console.WriteLine("2. Registrar Motocicleta");
                Console.WriteLine("3. Registrar Camión");
                Console.WriteLine("4. Ver Reporte de Facturas");
                Console.WriteLine("5. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "5")
                {
                    continuar = false;
                    continue;
                }

                if (opcion == "4")
                {
                    MostrarReporteFinal(ventas);
                    continue;
                }

                if (opcion == "1" || opcion == "2" || opcion == "3")
                {
                    Console.Clear();
                    string titulo = opcion == "1" ? "AUTO" : (opcion == "2" ? "MOTOCICLETA" : "CAMIÓN");
                    Console.WriteLine($"==== REGISTRAR NUEVO {titulo} ====\n");

                    Console.Write(" > ID: "); string id = Console.ReadLine();
                    Console.Write(" > Marca: "); string marca = Console.ReadLine();
                    Console.Write(" > Modelo: "); string modelo = Console.ReadLine();
                    Console.Write(" > Año: "); int year = int.Parse(Console.ReadLine());
                    Console.Write(" > Precio Base: "); decimal precio = decimal.Parse(Console.ReadLine());

                    Console.Write(" > Combustible (Gasolina/Diesel/Electrico/Hibrido): ");
                    TipoCombustible combustible = (TipoCombustible)Enum.Parse(typeof(TipoCombustible), Console.ReadLine(), true);

                    Console.Write(" > Estado (Nuevo/Usado/Seminuevo): ");
                    EstadoVehiculo estado = (EstadoVehiculo)Enum.Parse(typeof(EstadoVehiculo), Console.ReadLine(), true);

                    if (opcion == "1")
                    {
                        Console.Write(" > Número de puertas: "); int puertas = int.Parse(Console.ReadLine());
                        Console.Write(" > ¿Tiene Aire Acondicionado? (si/no): ");
                        bool aire = Console.ReadLine().ToLower() == "si";
                        ventas.Add(new Auto(id, marca, modelo, year, precio, combustible, estado, puertas, aire));
                    }
                    else if (opcion == "2")
                    {
                        Console.Write(" > Cilindraje (CC): "); int cc = int.Parse(Console.ReadLine());
                        Console.Write(" > ¿Es deportiva? (si/no): ");
                        bool deportiva = Console.ReadLine().ToLower() == "si";
                        ventas.Add(new Motocicleta(id, marca, modelo, year, precio, combustible, estado, cc, deportiva));
                    }
                    else if (opcion == "3")
                    {
                        Console.Write(" > Capacidad Carga (Ton): "); decimal carga = decimal.Parse(Console.ReadLine());
                        Console.Write(" > Número de ejes: "); int ejes = int.Parse(Console.ReadLine());
                        ventas.Add(new Camion(id, marca, modelo, year, precio, combustible, estado, carga, ejes));
                    }

                    Console.WriteLine($"\n[OK] {titulo} registrado con éxito.");
                    Console.WriteLine("Presione una tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        static void MostrarReporteFinal(List<IVendible> ventas)
        {
            Console.Clear();
            Console.WriteLine("======= REPORTE DE VENTAS TOTALES =======\n");

            if (ventas.Count == 0)
            {
                Console.WriteLine(" No hay vehículos registrados aún.");
            }
            else
            {
                foreach (var v in ventas)
                {
                    v.GenerarFacturaVenta();
                    Console.WriteLine("----------------------------------------");
                }
            }

            Console.WriteLine("\nFin del reporte. Presione una tecla para volver.");
            Console.ReadKey();
        }
    }
}
