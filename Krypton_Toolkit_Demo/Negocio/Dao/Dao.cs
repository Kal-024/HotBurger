using System.Collections.Generic;
using System.Data;

namespace Krypton_Toolkit_Demo.Negocio.Dao
{
    public interface IDao <T>
    {
        DataTable GetAll();
        T GetById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
