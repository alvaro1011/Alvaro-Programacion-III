using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using tipo_parcial_2.ConcesionarioVehiculos.enums;
using tipo_parcial_2.ConcesionarioVehiculos.Interfaces;

namespace tipo_parcial_2.ConcesionarioVehiculos.modelos
{
    public abstract class Vehiculo
    {
        public string Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public decimal PrecioBase { get; set; }
        public TipoCombustible Combustible { get; set; }
        public EstadoVehiculo Estado { get; set; }

        protected Vehiculo(string Id, string Marca, string Modelo, int Año, decimal PrecioBase, TipoCombustible Combustible, EstadoVehiculo Estado)
        {
            this.Id = Id;
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Año = Año;
            this.PrecioBase = PrecioBase;
            this.Combustible = Combustible;
            this.Estado = Estado;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine("======== INFORMACIÓN: VEHICULO ========");
            Console.WriteLine($"Id del Vehiculo: {Id}");
            Console.WriteLine($"Marca del Vehiculo: {Marca}");
            Console.WriteLine($"Modelo del Vehiculo: {Modelo}");
            Console.WriteLine($"Año del Vehiculo: {Año}");
            Console.WriteLine($"Precio Base: {PrecioBase}");
            Console.WriteLine($"Combustible: {Combustible}");
            Console.WriteLine($"Estado: {Estado}");
        }
    }
}
