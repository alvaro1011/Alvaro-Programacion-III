using parcial_practica2.Healt_Tech.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_practica2.Healt_Tech.modelos
{
    public class CitaMedica : IPrioritario
    {
        public string Paciente { get; set; }
        public Especialidad Especialidad { get; set; }

        public double CostoBase { get; set; }

        public CitaMedica(string Paciente, Especialidad Especialidad, double CostoBase)
        { 
            this.Paciente = Paciente;
            this.Especialidad = Especialidad;
            this.CostoBase = CostoBase;
        }

        public string ToCSV() => $"{Paciente},{Especialidad},{CostoBase}";

        public double AplicarDescuento()
        {
            double descuento = 0;
            switch (Especialidad)
            {
                case Especialidad.Pediatria:
                    descuento = 0.20;
                    break;
            }
            return CostoBase * (CostoBase - descuento);
        }
    }
}
