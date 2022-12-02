using Krypton_Toolkit_Demo.Negocio.Dao;
using Krypton_Toolkit_Demo.Negocio.Util;
using System.Collections.Generic;

namespace Krypton_Toolkit_Demo.Negocio.Interfaces
{
    internal interface InsumoDao<T>: IDao<T>
    {
        List<T> getAllInsumos();
        Usuario getUsuario();
    }
}
