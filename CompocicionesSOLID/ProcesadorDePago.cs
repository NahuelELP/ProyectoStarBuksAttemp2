using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompocicionesSOLID
{
    internal class ProcesadorDePago
    {
        private IPago pago;
        public ProcesadorDePago(IPago pago)
        {
            this.pago = pago;
        }
        public void ProcesarPago(double monto)
        {
            pago.Pagar(monto);
        }
    }
}
