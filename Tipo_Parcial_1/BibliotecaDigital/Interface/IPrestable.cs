using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercio_parcial.BibliotecaDigital.Interface
{
    public interface IPrestable
    {

        DateTime CalcularFechaDevolcion();
        void GenerarComprobantePrestamo();
        decimal CalcularMultaPorRetraso(int diasRetraso);

    }
}
