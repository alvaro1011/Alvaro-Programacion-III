using ejercio_parcial.BibliotecaDigital.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ejercio_parcial.BibliotecaDigital.Modelos
{
    public class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public int ISBN { get; set; }

        public Libro(string titulo, string autor, int id, int anioPublicacion, string categoria, int numeroPaginas, int isbn)
            : base(titulo, autor, id, anioPublicacion, categoria)
        {
            this.NumeroPaginas = numeroPaginas;
            this.ISBN = isbn;
        }

        public void virtual nformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
        
        public DateTime CalcularFechaDevolcion()
        {
            return DateTime.Now.AddDays(14);
        }
        public void Prestar()
        {
           
        }

        public void Devolver()
        {
            
        }
    }
}
