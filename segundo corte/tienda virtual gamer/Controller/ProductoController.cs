using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using tienda_virtual_gamer.Models;

namespace tienda_virtual_gamer.Controller
{
    public class ProductoController
    {
        private readonly CsvReader _csvReader;

        public ProductoController()
        {
            _csvReader = new CsvReader();
        }

        // ── Rutas ──────────────────────────────────────────────────
        private string ObtenerRutaProductos()
        {
            string carpeta = ObtenerCarpeta();
            if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, "Productos.csv");
        }

        private string ObtenerRutaEntradas()
        {
            string carpeta = ObtenerCarpeta();
            if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, "Entrada.csv");
        }

        private string ObtenerRutaSalidas()
        {
            string carpeta = ObtenerCarpeta();
            if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);
            return Path.Combine(carpeta, "Salida.csv");
        }

        private string ObtenerCarpeta()
        {
            string ruta_app = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            return Path.Combine(ruta_app, "DataUser");
        }

        // ── Archivos ───────────────────────────────────────────────
        public void CrearArchivos()
        {
            foreach (string ruta in new[] { ObtenerRutaProductos(), ObtenerRutaEntradas(), ObtenerRutaSalidas() })
                if (!File.Exists(ruta))
                    File.Create(ruta).Dispose();
        }

        // ── Lectura — ahora delega en CsvReader ───────────────────
        public List<Producto> ObtenerProductos()
        {
            List<Producto> lista = new List<Producto>();

            foreach (string[] datos in _csvReader.CargarCsvProductos())
            {
                lista.Add(new Producto
                {
                    Codigo = datos[0],
                    Nombre = datos[1],
                    Categoria = datos[2],
                    Precio = decimal.Parse(datos[3]),
                    Cantidad = int.Parse(datos[4])
                });
            }

            return lista;
        }

        public List<string[]> CargarEntradas() => _csvReader.CargarCsvEntradas();
        public List<string[]> CargarSalidas() => _csvReader.CargarCsvSalidas();

        // ── Escritura ──────────────────────────────────────────────
        public void AgregarProducto(Producto producto)
        {
            string ruta = ObtenerRutaProductos();
            bool esNuevo = !File.Exists(ruta) || new FileInfo(ruta).Length == 0;

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                if (esNuevo)
                    escritor.WriteLine("Codigo;Nombre;Categoria;Precio;Cantidad");

                escritor.WriteLine($"{producto.Codigo};{producto.Nombre};{producto.Categoria};{producto.Precio};{producto.Cantidad}");
            }
        }

        public void RegistrarEntrada(string codigo, string nombre, int cantidad, string observacion)
        {
            string ruta = ObtenerRutaEntradas();
            bool esNuevo = !File.Exists(ruta) || new FileInfo(ruta).Length == 0;

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                if (esNuevo)
                    escritor.WriteLine("Fecha;Codigo;Nombre;Cantidad;Observacion");

                escritor.WriteLine($"{DateTime.Now:dd/MM/yyyy};{codigo};{nombre};+{cantidad};{observacion}");
            }

            LimpiarLineasVacias(ruta);
        }

        public void RegistrarSalida(string codigo, string nombre, int cantidad, string observacion)
        {
            string ruta = ObtenerRutaSalidas();
            bool esNuevo = !File.Exists(ruta) || new FileInfo(ruta).Length == 0;

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                if (esNuevo)
                    escritor.WriteLine("Fecha;Codigo;Nombre;Cantidad;Observacion");

                escritor.WriteLine($"{DateTime.Now:dd/MM/yyyy};{codigo};{nombre};-{cantidad};{observacion}");
            }

            LimpiarLineasVacias(ruta);
        }

        public void ActualizarCantidad(string codigo, int cantidadSumar)
        {
            string ruta = ObtenerRutaProductos();
            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] datos = lineas[i].Split(';');

                if (datos[0].Trim() == codigo.Trim())
                {
                    datos[4] = (int.Parse(datos[4]) + cantidadSumar).ToString();
                    lineas[i] = string.Join(";", datos);
                    break;
                }
            }

            File.WriteAllLines(ruta, lineas, Encoding.UTF8);
        }

        public void RestarCantidad(string codigo, int cantidadRestar)
        {
            string ruta = ObtenerRutaProductos();
            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] datos = lineas[i].Split(';');

                if (datos[0].Trim() == codigo.Trim())
                {
                    int actual = int.Parse(datos[4]);
                    datos[4] = Math.Max(0, actual - cantidadRestar).ToString();
                    lineas[i] = string.Join(";", datos);
                    break;
                }
            }

            File.WriteAllLines(ruta, lineas, Encoding.UTF8);
        }

        public bool CodigoExiste(string codigo) =>
            ObtenerProductos().Exists(p => p.Codigo == codigo);

        public List<string> ObtenerProductosParaComboBox()
        {
            List<string> items = new List<string>();
            foreach (Producto p in ObtenerProductos())
                items.Add($"{p.Codigo} - {p.Nombre}");
            return items;
        }

        // ── Utilidad privada ───────────────────────────────────────
        private void LimpiarLineasVacias(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);
            File.WriteAllLines(ruta, Array.FindAll(lineas, l => !string.IsNullOrWhiteSpace(l)), Encoding.UTF8);
        }
    }
}