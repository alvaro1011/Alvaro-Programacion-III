using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneStore.Modelo
{
    public class Informes
    {
        public DateTime Fecha { get; set; }
        public string TipoMovimiento { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public int StockActual { get; set; }
    }
}
