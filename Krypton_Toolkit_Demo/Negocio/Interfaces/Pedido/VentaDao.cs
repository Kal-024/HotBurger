using Krypton_Toolkit_Demo.Negocio.Dao;
using System;
using System.Data;

namespace Krypton_Toolkit_Demo.Negocio.Interfaces
{
    internal interface VentaDao<T> : IDao<T>
    {
        DataTable  GetVentaByDate(DateTime d);
    }
}
