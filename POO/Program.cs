using System;

namespace POO {
    internal class Program {
        static void Main(string[] args) {

            // Instancia de la clase Cuenta Bancaria
            CuentaBancaria cuenta1 = new CuentaBancaria();
            CuentaBancaria cuenta2 = new CuentaBancaria();

            cuenta1.Saldo = 1500;
            cuenta2.Saldo = 2200;

            try
            {
                PuntoEncapsulado puntoEnc = new PuntoEncapsulado();

                puntoEnc.setXPrivate(90);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
