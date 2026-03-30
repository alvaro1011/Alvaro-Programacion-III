using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_Parcial_3.SistemaRestaurante.Interfaces
{
    public interface IPreparable
    {
        DateTime CalcularTiempoPreparacion();
        void GenerarOrdenCocina();
        decimal CalcularCostoTotal();
    }
}
