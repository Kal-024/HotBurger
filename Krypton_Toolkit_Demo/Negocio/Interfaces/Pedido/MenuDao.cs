using Krypton_Toolkit_Demo.Negocio.Dao;

namespace Krypton_Toolkit_Demo.Negocio.Interfaces
{
    internal interface MenuDao<T> : IDao<T>
    {
        bool updateInventario(int cantidad);
    }
}
