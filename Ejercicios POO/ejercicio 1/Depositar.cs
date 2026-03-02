using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_POO.ejercicio_1
{
    public class Depositar : Cuenta_bancaria
    {
        public double MontoADepositar;

        public Depositar(string titular, double saldoInicial, double montoADepositar) : base(titular, saldoInicial)
        {
            this.MontoADepositar = montoADepositar;
        }
        public void HacerDeposito()
        {
            if (MontoADepositar > 0)
            {
                Console.Clear();
                this.Saldo += MontoADepositar;
                Console.WriteLine("==== Deposito realizado ====");
                Console.WriteLine("Titular: " + Titlar);
                Console.WriteLine("Monto sumado: $" + MontoADepositar);
                Console.WriteLine("Saldo Actualizado: $" + Saldo);
                Console.Write("\nPor favor, para continuar, presiona Enter...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nError: El monto debe ser mayor a cero.");
            }
        }
    }
}
