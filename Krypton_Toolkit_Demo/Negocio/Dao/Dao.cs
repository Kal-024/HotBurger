using System.Collections.Generic;

namespace Krypton_Toolkit_Demo.Negocio.Dao
{
    public interface Dao <T>
    {
        List<T> getAll();
        T getById(int id);
        bool create(T entity);
        bool update(T entity);
        bool delete(T entity);
    }
}
