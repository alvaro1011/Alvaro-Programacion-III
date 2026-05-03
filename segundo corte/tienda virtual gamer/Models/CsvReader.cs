using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace tienda_virtual_gamer.Models
{
    public class CsvReader
    {
        private string ObtenerRutaBase()
        {
            string ruta_app = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            return Path.Combine(ruta_app, "DataUser");
        }

        private List<string[]> LeerCsv(string nombreArchivo)
        {
            List<string[]> lista = new List<string[]>();
            string ruta = Path.Combine(ObtenerRutaBase(), nombreArchivo);

            if (!File.Exists(ruta)) return lista;

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++) // i=1 para saltar encabezado
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;

                string[] datos = lineas[i].Split(';');
                if (datos.Length < 5) continue;

                bool todosVacios = true;
                foreach (string d in datos)
                    if (!string.IsNullOrWhiteSpace(d)) { todosVacios = false; break; }

                if (todosVacios) continue;

                lista.Add(datos);
            }

            return lista;
        }

        public List<string[]> CargarCsvProductos() => LeerCsv("Productos.csv");
        public List<string[]> CargarCsvEntradas() => LeerCsv("Entrada.csv");
        public List<string[]> CargarCsvSalidas() => LeerCsv("Salida.csv");
    }
}