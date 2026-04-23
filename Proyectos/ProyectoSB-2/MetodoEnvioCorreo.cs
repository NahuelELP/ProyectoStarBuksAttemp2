using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSB_2
{
    internal class MetodoEnvioCorreo : IMetodoEnvio
    {
        public void Enviar(double monto)
        {
            Console.WriteLine("Envio por correo, monto: >${0}<",monto);
        }
    }
}
