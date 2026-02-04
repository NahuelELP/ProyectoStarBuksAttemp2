using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSB_2
{
    internal class MetodoEnvioDhl : IMetodoEnvio
    {
        public void Enviar(double monto)
        {
            Console.WriteLine("Envio por DHL, monto: >${0}<", monto);
        }
    }
}
