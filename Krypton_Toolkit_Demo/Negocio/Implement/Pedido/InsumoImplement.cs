using Krypton_Toolkit_Demo.Negocio.Dao;
using Krypton_Toolkit_Demo.Negocio.Entities.Classes;
using Krypton_Toolkit_Demo.Negocio.Interfaces;
using Krypton_Toolkit_Demo.Negocio.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Negocio.Implement.Pedido
{
    internal class InsumoImplement : InsumoDao<CInventario>
    {
        public bool create(CInventario entity)
        {
            throw new NotImplementedException();
        }

        public bool delete(CInventario entity)
        {
            throw new NotImplementedException();
        }

        public Usuario getUsuario()
        {
            throw new NotImplementedException();
        }

        public bool update(CInventario entity)
        {
            throw new NotImplementedException();
        }

        List<CInventario> Dao<CInventario>.getAll()
        {
            throw new NotImplementedException();
        }

        List<CInventario> InsumoDao<CInventario>.getAllInsumos()
        {
            throw new NotImplementedException();
        }

        CInventario Dao<CInventario>.getById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
