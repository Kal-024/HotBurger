using Krypton_Toolkit_Demo.Negocio.Entities.Classes;
using Krypton_Toolkit_Demo.Negocio.Interfaces.Inventario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton_Toolkit_Demo.Negocio.Implement.Inventario
{
    internal class InventarioDaoImplement : InventarioDao<CInventario>
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

        public CInventario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CInventario entity)
        {
            throw new NotImplementedException();
        }
    }
}
