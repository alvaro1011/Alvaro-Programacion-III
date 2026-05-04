using PhoneStore.Modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Controlador
{
    public class SalidaControlador
    {
        string ruta = "salidas.csv";
        public SalidaControlador()
        {
            // Asegurar que el archivo existe para evitar excepciones al leer
            if (!File.Exists(ruta))
            {
                File.WriteAllText(ruta, string.Empty);
            }
        }
        public void GuardarSalida(Modelo.Salidas salida)
        {
            string linea = salida.Fecha + "," +
                salida.CodigoProducto + "," +
                salida.NombreProducto + "," +
                salida.Cantidad + "," +
                salida.Observacion;
            File.AppendAllText(ruta, linea + Environment.NewLine);
        }
        public List<Salidas> ObtenerSalidas()
        {
            List<Salidas> salidas = new List<Salidas>();
            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);
                foreach (string linea in lineas)
                {
                    string[] datos = linea.Split(',');
                    Salidas salida = new Salidas
                    {
                        Fecha = DateTime.Parse(datos[0]),
                        CodigoProducto = datos[1],
                        NombreProducto = datos[2],
                        Cantidad = int.Parse(datos[3]),
                        Observacion = datos[4]
                    };
                    salidas.Add(salida);
                }
            }
            return salidas;
        }
    }
}
