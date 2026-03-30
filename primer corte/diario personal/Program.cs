using System;
using System.IO;
using System.Linq;

namespace diario_personal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            var nombre = Console.ReadLine();

            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "diario.txt");

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                Console.WriteLine();
                Console.WriteLine("Últimas entradas:");
                foreach (var line in lines.Skip(Math.Max(0, lines.Length - 3)))
                    Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.Write("Escribe tu pensamiento: ");
            var mensaje = Console.ReadLine() ?? string.Empty;

            var entry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - {nombre}: {mensaje}{Environment.NewLine}";
            File.AppendAllText(filePath, entry);

            Console.WriteLine("Guardado.");
        }
    }
}
