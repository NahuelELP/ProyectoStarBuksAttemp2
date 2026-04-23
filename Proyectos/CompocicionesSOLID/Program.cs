using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompocicionesSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcesadorDePago PagoPayPal = new ProcesadorDePago(new PagoPayPal());
            PagoPayPal.ProcesarPago(100);
            ProcesadorDePago PagoTarjeta = new ProcesadorDePago(new PagoTarjeta());
            PagoTarjeta.ProcesarPago(200);
        }
    }
}
/*
 IPago

 PagoTarjeta

 PagoPaypal

 ProcesadorPago
*/
