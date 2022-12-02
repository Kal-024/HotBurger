using Krypton_Toolkit_Demo.Negocio.Dao;
using System;

namespace Krypton_Toolkit_Demo.Negocio.Interfaces
{
    interface AbrirCajaDao<T> : IDao<T>
    {
        DateTime getDateTime();
    }
}
