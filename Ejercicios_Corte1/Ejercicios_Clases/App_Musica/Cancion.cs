using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Corte1.Ejercicios_Clases.App_Musica
{
    public class Cancion : IReproductor
    {
        public string Titulo;
        public string Artista;

        public Cancion(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
        }

        public void Play()
        {
            Console.WriteLine("Reproduciendo cancion: " + Titulo + " de " + Artista);
        }

        public void Stop()
        {
            Console.WriteLine("Pausando cancion: " + Titulo);
        }
    }
}