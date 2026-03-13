using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tipo_parcial_2.ConcesionarioVehiculos.enums;
using tipo_parcial_2.ConcesionarioVehiculos.Interfaces;

namespace tipo_parcial_2.ConcesionarioVehiculos.modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(string id, string marca, string modelo, int year, decimal preciobase, TipoCombustible combustible, EstadoVehiculo estado, int numeropuertas, bool tieneaireacondicionado)
            : base(id, marca, modelo, year, preciobase, combustible, estado)
        {
            this.NumeroPuertas = numeropuertas;
            this.TieneAireAcondicionado = tieneaireacondicionado;
        }

        public decimal CalcularPrecioFinal()
        {
            decimal precioFinal = PrecioBase;
            if (TieneAireAcondicionado) precioFinal += 2000;
            return precioFinal;
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.04m;
        }

        public void GenerarFacturaVenta()
        {
            MostrarInformacion();
            Console.WriteLine($"Número de puertas: {NumeroPuertas}");
            Console.WriteLine($"Aire Acondicionado: {(TieneAireAcondicionado ? "Sí" : "No")}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine($"Comisión Vendedor: {CalcularComisionVendedor()}");
        }
    }
}