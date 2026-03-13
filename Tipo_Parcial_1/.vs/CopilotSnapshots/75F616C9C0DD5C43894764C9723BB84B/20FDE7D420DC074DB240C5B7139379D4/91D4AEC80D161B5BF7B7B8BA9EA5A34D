using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercio_parcial.BibliotecaDigital.Modelos
{
    public class Revista
    {
        public int numeroedicion { get; set; };
        public string periodicidad { get; set; };

        public Revista (string titulo, string autor, int id, int anioPublicacion, string categoria, int numeroedicion , string periodicidad) : base (string titulo, string autor, int id, int anioPublicacion, string categoria)
        {
            this.numeroedicion = numeroedicion;
            this.periodicidad = periodicidad;
        }

        public void virtual MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"numero de edicion : {numeroedicion}");
            Console.WriteLine($"periodicidad : {periodicidad}");
        }
    }
}
