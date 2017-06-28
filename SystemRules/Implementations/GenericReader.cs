using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class GenericReader<T> : IRead<T>
        where T : Entity
    {
        public IEnumerable<T> ReadAll()
        {
            return new T[0];
        }

        public T ReadOne(int id)
        {
            return default(T);
        }
    }
}
