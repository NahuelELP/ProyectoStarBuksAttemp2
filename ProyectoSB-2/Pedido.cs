using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSB_2
{
    internal class Pedido
    {
        private double total;
        private IMetodoEnvio metodoEnvio;

        public Pedido(IMetodoEnvio metodoEnvio, double total)
        {
            this.metodoEnvio = metodoEnvio;
            this.total = total;
        }
        public void Enviar()
        {
            metodoEnvio.Enviar(total);
        }
    }
}
