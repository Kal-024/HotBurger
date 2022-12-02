using System;
using System.Collections.Generic;

namespace Krypton_Toolkit_Demo.Negocio.Entities.Classes
{
    internal class PedidoAbastecimiento
    {
        int idPedido;
        DateTime fechaEntrega;
        DateTime fechaPedido;
        List<CInventario> inventarioLista;
        float costo;

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public DateTime FechaEntrega { get => fechaEntrega; set => fechaEntrega = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public float Costo { get => costo; set => costo = value; }
        internal List<CInventario> InventarioLista { get => inventarioLista; set => inventarioLista = value; }
    }
}
