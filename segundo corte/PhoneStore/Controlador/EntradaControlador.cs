using PhoneStore.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Controlador
{
    public class EntradaControlador
    {
        string ruta = "entradas.csv";
        public void GuardarEntrada(Modelo.Entradas entrada)
        {
            string linea = entrada.Fecha + "," +
                entrada.CodigoProducto + "," +
                entrada.NombreProducto + "," +
                entrada.Cantidad + "," +
                entrada.Observacion;
            File.AppendAllText(ruta, linea + Environment.NewLine);
        }
        public List<Entradas> ObtenerEntradas()
        {
            List<Entradas> entradas = new List<Entradas>();
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    Entradas entrada = new Entradas
                    {
                        Fecha = DateTime.Parse(datos[0]),
                        CodigoProducto = datos[1],
                        NombreProducto = datos[2],
                        Cantidad = int.Parse(datos[3]),
                        Observacion = datos[4]
                    };
                    entradas.Add(entrada);
                }
            }
            return entradas;
        }
    }
}
