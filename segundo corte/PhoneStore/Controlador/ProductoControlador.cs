using PhoneStore.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Controlador
{
    public class ProductoControlador
    {
        string ruta = "productos.csv";
        public void GuardarProducto(Modelo.Productos producto)
        {
            string linea = producto.Codigo + "," + 
                producto.Nombre + "," + 
                producto.Categoria + "," + 
                producto.Precio + "," + 
                producto.Stock;

            File.AppendAllText(ruta, linea + Environment.NewLine);
        }
        public List<Productos> ObtenerProductos()
        {
            List<Productos> lista = new List<Productos>();

            if (!File.Exists(ruta))
                return lista;

            string[] lineas = File.ReadAllLines(ruta);

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                if (datos.Length == 5)
                {
                    Productos producto = new Productos();

                    producto.Codigo = datos[0];
                    producto.Nombre = datos[1];
                    producto.Categoria = datos[2];
                    producto.Precio = decimal.Parse(datos[3]);
                    producto.Stock = int.Parse(datos[4]);

                    lista.Add(producto);
                }
            }
            return lista;
        }
        public void ActualizarProductos(List<Productos> productos)
        {
            List<string> lineas = new List<string>();

            foreach (Productos producto in productos)
            {
                string linea = producto.Codigo + "," +
                               producto.Nombre + "," +
                               producto.Categoria + "," +
                               producto.Precio + "," +
                               producto.Stock;

                lineas.Add(linea);
            }

            File.WriteAllLines(ruta, lineas);
        }

        public void EliminarProducto(string codigo)
        {
            List<Productos> productos = ObtenerProductos();

            productos.RemoveAll(p => p.Codigo == codigo);

            ActualizarProductos(productos);
        }

        public Productos BuscarProducto(string codigo)
        {
            List<Productos> productos = ObtenerProductos();

            foreach (Productos producto in productos)
            {
                if (producto.Codigo == codigo)
                {
                    return producto;
                }
            }

            return null;
        }
    }
}