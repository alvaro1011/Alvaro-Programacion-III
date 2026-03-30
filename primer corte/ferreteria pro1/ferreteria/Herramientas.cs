using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ferreteria_pro1.ferreteria
{
    public class Herramientas 
    {
        public int id {  get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }

        public Herramientas (int id, string descripcion, double precio)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
        }
        public string ToCSV() => $"{id},{descripcion},{precio}";

    }
}
