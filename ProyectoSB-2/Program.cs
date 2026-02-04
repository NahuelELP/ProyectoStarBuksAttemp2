using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSB_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pedido pedidoCorreo = new Pedido(new MetodoEnvioCorreo(), 150.0);
            pedidoCorreo.Enviar();
            Pedido pedidoDhl = new Pedido(new MetodoEnvioDhl(), 250.0);
            pedidoDhl.Enviar();
            Pedido pedidoMensajeria = new Pedido(new MetodoEnvioMensajeria(), 350.0);
            pedidoMensajeria.Enviar();
        }
    }
}
