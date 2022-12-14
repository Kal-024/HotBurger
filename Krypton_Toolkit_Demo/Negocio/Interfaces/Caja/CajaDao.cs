using Krypton_Toolkit_Demo.Negocio.Dao;
using Krypton_Toolkit_Demo.Negocio.Util;

namespace Krypton_Toolkit_Demo.Negocio.Interfaces
{
    internal interface CajaDao<T> : IDao<T>
    {
        Usuario obtenerUsuario(int IdUsuario);
    }
}
