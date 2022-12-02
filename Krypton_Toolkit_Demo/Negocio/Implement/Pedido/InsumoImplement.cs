using Krypton_Toolkit_Demo.Negocio.Dao;
using Krypton_Toolkit_Demo.Negocio.Entities.Classes;
using Krypton_Toolkit_Demo.Negocio.Interfaces;
using Krypton_Toolkit_Demo.Negocio.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Negocio.Implement.Pedido
{
    internal class InsumoImplement : InsumoDao<CInventario>
    {
        public bool Create(CInventario entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CInventario entity)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario getUsuario()
        {
            throw new NotImplementedException();
        }

        public bool Update(CInventario entity)
        {
            throw new NotImplementedException();
        }

       
        List<CInventario> InsumoDao<CInventario>.getAllInsumos()
        {
            throw new NotImplementedException();
        }

        CInventario IDao<CInventario>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
