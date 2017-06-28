using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
