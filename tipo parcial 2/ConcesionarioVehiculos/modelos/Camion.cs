using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipo_parcial_2.ConcesionarioVehiculos.enums;
using tipo_parcial_2.ConcesionarioVehiculos.Interfaces;

namespace tipo_parcial_2.ConcesionarioVehiculos.modelos
{
    public class Camion: Vehiculo , IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(string id, string marca, string modelo, int year, decimal preciobase, TipoCombustible combustible, EstadoVehiculo estado, decimal capacidadcarga, int numeroejes)
            : base(id, marca, modelo, year, preciobase, combustible, estado)
        {
            this.CapacidadCarga = capacidadcarga;
            this.NumeroEjes = numeroejes;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.05m;
        }

        public void GenerarFacturaVenta()
        {
            MostrarInformacion();
            Console.WriteLine($"Capacidad Carga: {CapacidadCarga} Ton");
            Console.WriteLine($"Número de Ejes: {NumeroEjes}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine($"Comisión Vendedor: {CalcularComisionVendedor()}");
        }
    }
}
