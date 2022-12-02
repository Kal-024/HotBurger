using Krypton_Toolkit_Demo.Negocio.Implement.Pedido;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Controladora.Pedido
{
    internal class VentaServices
    {
        VentaDaoImplement vdi = new VentaDaoImplement();
        public DataTable ObtenerVentasFacturaPorFecha(DateTime Fecha)
        {
            return vdi.GetVentaByDate(Fecha);
        }
    }
}
