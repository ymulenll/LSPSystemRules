using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISave<T>
         where T : Entity
    {
        void Save(T entity);
    }
}
