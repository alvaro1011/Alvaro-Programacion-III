using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO.ejercicio_1
{
    public class Retirar : Cuenta_bancaria
    {
        // Campo privado que almacena la cantidad a retirar
        private double MontoARetirar;

        // Constructor: recibe titular, saldo inicial y cantidad a retirar
        public Retirar(string titular, double saldoInicial, double cantidadARetirar) : base(titular, saldoInicial)
        {
            this.MontoARetirar = cantidadARetirar;
        }

        // Método público para realizar el retiro
        public void HacerRetiro()
        {
            if (this.MontoARetirar <= Saldo && this.MontoARetirar > 0)
            {
                Console.Clear();
                this.Saldo = Saldo - this.MontoARetirar;
                Console.WriteLine("==== Retiro realizado ====");
                Console.WriteLine($"Titular: {Titlar}");
                Console.WriteLine($"Se retiraron: ${this.MontoARetirar}");
                Console.WriteLine($"Saldo restante: ${Saldo}");
                Console.Write("\nPor favor, para continuar, presiona Enter...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nERROR: Fondos insuficientes o monto inválido para retirar $" + this.MontoARetirar);
                Console.Write("\nPor favor, para continuar, presiona Enter...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
