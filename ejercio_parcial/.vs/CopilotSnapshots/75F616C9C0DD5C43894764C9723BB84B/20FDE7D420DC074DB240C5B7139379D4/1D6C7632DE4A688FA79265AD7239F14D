using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercio_parcial.BibliotecaDigital.Modelos
{
    public class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public int duracion { get; set; };
        public string autorNarracion { get; set; };

        public AudioLibro(string titulo, string autor, int id, int anioPublicacion, string categoria, int duracion, string autorNarracion)
            : base(titulo, autor, id, anioPublicacion, categoria)
        {
            this.duracion = duracion;
            this.autorNarracion = autorNarracion;
        }

        public void virtual MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {duracion} minutos");
            Console.WriteLine($"Autor de Narración: {autorNarracion}");
        }
    }
}
