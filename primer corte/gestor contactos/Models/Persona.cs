using System;

namespace gestor_contactos.Models
{
    
    public class Persona
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string telefono)
        {
            if (nombre != null)
                Nombre = nombre;
            else
                Nombre = string.Empty;

            if (telefono != null)
                Telefono = telefono;
            else
                Telefono = string.Empty;
        }
    }
}
