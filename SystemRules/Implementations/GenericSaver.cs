using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class GenericSaver<T> : ISave<T>
        where T : Entity
    {
        public void Save(T entity)
        {
            
        }
    }
}
