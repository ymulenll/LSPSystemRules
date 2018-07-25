using Model;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IReadSave<T>
        where T : Entity
    {
        T ReadOne(int id);

        IEnumerable<T> ReadAll();

        void Save(T entity);
    }
}
