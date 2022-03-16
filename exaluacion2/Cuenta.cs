using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exaluacion2
{
    internal class Cuenta
    {
        public int numeroCuenta { get; set; }
        public int documento { get; set; }
        public int saldoActual { get; set; }
        public int interesAnual { get; set; }
        public string actualizarSaldo { get; set; }
        public double ingresar { get; set; }
        public double retirar { get; set; }

        Cuenta(int numeroCuenta, int documento, int saldo, int interesAnual)
        {
            numeroCuenta = 198765432;
            documento = 1001686125;
            saldo = 10000;
            interesAnual = 2;


        }

        public Cuenta()
        {
        }
    }
}
