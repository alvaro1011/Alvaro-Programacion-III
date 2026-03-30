using System;

namespace gestor_contactos.Models
{
    
    public class ContactoTrabajo : Contacto
    {
        public string Empresa { get; set; }

        public ContactoTrabajo(string nombre, string telefono, string correo, string empresa)
            : base(nombre, telefono, correo)
        {
            if (empresa != null)
                Empresa = empresa;
            else
                Empresa = string.Empty;
        }

        public override string ToCSV()
        {
            return base.ToCSV() + ";" + Empresa;
        }
    }
}
