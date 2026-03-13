using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tipo_Parcial_3.SistemaRestaurante.Enums;
using Tipo_Parcial_3.SistemaRestaurante.Modelos;

namespace Tipo_Parcial_3
{
 public class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }

        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("       SISTEMA DE GESTIÓN GASTRO-APP        ");
            Console.WriteLine("============================================");
            Console.WriteLine("\n¿Qué tipo de plato desea pedir?");
            Console.WriteLine("  1. [Entrada]");
            Console.WriteLine("  2. [Plato Principal]");
            Console.WriteLine("  3. [Postre]");
            Console.WriteLine("\n--------------------------------------------");
            Console.Write("Seleccione una opción: ");

            int plato = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (plato)
            {
                case 1:
                    {
                        Console.WriteLine(">>> REGISTRO DE ENTRADA <<<");
                        Console.Write("Ingrese el ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Nombre de la entrada: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Descripción: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("Precio base: ");
                        decimal preciobase = decimal.Parse(Console.ReadLine());

                        TipoComida tipo_comida = CalcularTipoComida();
                        NivelDificultad dificultad = CalcularDificultad();
                        EstadoOrden estado_orden = CalcularEstadoOrden();

                        Console.WriteLine("\n¿Es una entrada fría?");
                        Console.WriteLine("  1- SÍ / Cualquier otro número- NO");
                        bool esfria = false;
                        int fria = int.Parse(Console.ReadLine());
                        if (fria == 1) esfria = true;

                        Console.Write("Número de porciones: ");
                        int porciones = int.Parse(Console.ReadLine());

                        Entrada entrada1 = new Entrada(id, nombre, descripcion, preciobase, tipo_comida, dificultad, estado_orden, esfria, porciones);

                        Console.WriteLine("\n--- PROCESANDO INFORMACIÓN ---");
                        entrada1.MostrarInformacionNutricional();
                        entrada1.CalcularTiempoPreparacion();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(">>> REGISTRO DE PLATO PRINCIPAL <<<");
                        Console.Write("Ingrese el ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Nombre del plato: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Descripción: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("Precio base: ");
                        decimal preciobase = decimal.Parse(Console.ReadLine());

                        TipoComida tipo_comida = CalcularTipoComida();
                        NivelDificultad dificultad = CalcularDificultad();
                        EstadoOrden estado_orden = CalcularEstadoOrden();

                        Console.Write("Proteína principal: ");
                        string proteinaprincipal = Console.ReadLine();

                        Console.WriteLine("\n¿Incluye Guarnición?");
                        Console.WriteLine("  1- SÍ / Cualquier otro número- NO");
                        bool incluyeguarnicion = false;
                        int guarnicion = int.Parse(Console.ReadLine());
                        if (guarnicion == 1) incluyeguarnicion = true;

                        PlatoPrincipal plato1 = new PlatoPrincipal(id, nombre, descripcion, preciobase, tipo_comida, dificultad, estado_orden, proteinaprincipal, incluyeguarnicion);

                        Console.WriteLine("\n--- PROCESANDO INFORMACIÓN ---");
                        plato1.MostrarInformacionNutricional();
                        plato1.CalcularTiempoPreparacion();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(">>> REGISTRO DE POSTRE <<<");
                        Console.Write("Ingrese el ID: ");
                        string id = Console.ReadLine();
                        Console.Write("Nombre del postre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Descripción: ");
                        string descripcion = Console.ReadLine();
                        Console.Write("Precio base: ");
                        decimal preciobase = decimal.Parse(Console.ReadLine());

                        TipoComida tipo_comida = CalcularTipoComida();
                        NivelDificultad dificultad = CalcularDificultad();
                        EstadoOrden estado_orden = CalcularEstadoOrden();

                        Console.WriteLine("\n¿Contiene lactosa?");
                        Console.WriteLine("  1- SÍ / Cualquier otro número- NO");
                        bool contienelactosa = false;
                        int lactosa = int.Parse(Console.ReadLine());
                        if (lactosa == 1) contienelactosa = true;

                        Console.Write("Calorías por porción: ");
                        int caloriasxporcion = int.Parse(Console.ReadLine());

                        Postre postre1 = new Postre(id, nombre, descripcion, preciobase, tipo_comida, dificultad, estado_orden, caloriasxporcion, contienelactosa);

                        Console.WriteLine("\n--- PROCESANDO INFORMACIÓN ---");
                        postre1.MostrarInformacionNutricional();
                        postre1.CalcularTiempoPreparacion();
                        break;
                    }
            }
            Console.WriteLine("\n============================================");
            Console.WriteLine("      OPERACIÓN FINALIZADA CON ÉXITO        ");
            Console.WriteLine("============================================");
        }

        private static TipoComida CalcularTipoComida()
        {
            Console.WriteLine("\n--- Categoría de Comida ---");
            Console.WriteLine(" 1. Vegetariana | 2. Básico | 3. Carnívora");
            Console.WriteLine(" 4. Mariscos    | 5. Mixta");
            Console.Write("Seleccione tipo: ");

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: return TipoComida.Vegetariana;
                case 2: return TipoComida.Basico;
                case 3: return TipoComida.Carnivora;
                case 4: return TipoComida.Mariscos;
                case 5: return TipoComida.Mixta;
                default:
                    Console.WriteLine("(!) Valor no reconocido. Asignando Desconocida.");
                    return TipoComida.Desconocida;
            }
        }

        private static NivelDificultad CalcularDificultad()
        {
            Console.WriteLine("\n--- Nivel de Complejidad ---");
            Console.WriteLine(" 1. Fácil | 2. Intermedio | 3. Avanzado");
            Console.Write("Seleccione dificultad: ");

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: return NivelDificultad.Facil;
                case 2: return NivelDificultad.Intermedio;
                case 3: return NivelDificultad.Avanzado;
                default:
                    Console.WriteLine("(!) Dificultad no reconocida.");
                    return NivelDificultad.Desconocido;
            }
        }

        private static EstadoOrden CalcularEstadoOrden()
        {
            Console.WriteLine("\n--- Estado de la Orden ---");
            Console.WriteLine(" 1. Pendiente | 2. Preparado | 3. Listo | 4. Entregado");
            Console.Write("Seleccione estado: ");

            int menu = int.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1: return EstadoOrden.Pediente;
                case 2: return EstadoOrden.Preparado;
                case 3: return EstadoOrden.Listo;
                case 4: return EstadoOrden.Entregado;
                default:
                    return EstadoOrden.Desconocido;
            }
        }
    }
}
