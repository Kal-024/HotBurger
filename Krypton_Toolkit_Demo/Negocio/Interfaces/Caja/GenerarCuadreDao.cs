using Krypton_Toolkit_Demo.Negocio.Dao;

namespace Krypton_Toolkit_Demo.Negocio.Interfaces
{
    internal interface GenerarCuadreDao<T> : Dao<T>
    {
        float setBilletes();
        float setMonedas();
        float setTarjeta();
    }
}
