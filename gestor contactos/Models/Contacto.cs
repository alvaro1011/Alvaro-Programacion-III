using System;

namespace gestor_contactos.Models
{
    // Contacto principal con correo y método ToCSV
    public class Contacto : Persona
    {
        public string Correo { get; set; }

        public Contacto(string nombre, string telefono, string correo)
            : base(nombre, telefono)
        {
            if (correo != null)
                Correo = correo;
            else
                Correo = string.Empty;
        }

        public virtual string ToCSV()
        {
            
            return string.Format("{0};{1};{2}", Nombre, Telefono, Correo);
        }
    }
}
