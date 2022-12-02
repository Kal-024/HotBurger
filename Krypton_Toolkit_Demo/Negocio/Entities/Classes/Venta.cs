using System;
using System.Collections.Generic;

namespace Krypton_Toolkit_Demo.Negocio.Entities.Classes
{
    internal class Venta
    {
        const double TASACAMBIODOLAR = 36.7;
        const double IMPUESTO = 0.3;

        int id;
        float tasaCambioDolar;
        DateTime fecha;
        List<Menu> pedido;
        float subtotal;
        float impuesto;
        float Descuento;
        float Total;
        int IdUsuario;
        TipoPago tipoPago;
        EstadoVenta estadoVenta;

        public int Id { get => id; set => id = value; }
        public float TasaCambioDolar { get => tasaCambioDolar; set => tasaCambioDolar = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Subtotal { get => subtotal; set => subtotal = value; }
        public float Impuesto { get => impuesto; set => impuesto = value; }
        public float Descuento1 { get => Descuento; set => Descuento = value; }
        public float Total1 { get => Total; set => Total = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public TipoPago TipoPago { get => tipoPago; set => tipoPago = value; }
        public EstadoVenta EstadoVenta { get => estadoVenta; set => estadoVenta = value; }
        internal List<Menu> Pedido { get => pedido; set => pedido = value; }
    }

    
}
