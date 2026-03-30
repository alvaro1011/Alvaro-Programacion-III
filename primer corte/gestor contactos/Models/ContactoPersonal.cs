using System;

namespace gestor_contactos.Models
{
    
    public class ContactoPersonal : Contacto
    {
        public string Relacion { get; set; }

        public ContactoPersonal(string nombre, string telefono, string correo, string relacion)
            : base(nombre, telefono, correo)
        {
            if (relacion != null)
                Relacion = relacion;
            else
                Relacion = string.Empty;
        }

        public override string ToCSV()
        {
            
            return base.ToCSV() + ";" + Relacion;
        }
    }
}
