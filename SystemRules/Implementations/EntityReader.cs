using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class EntityReader : IRead<Entity>
    {
        public Entity ReadOne(int id)
        {
            if (id == 0)
                throw new EntityNotFoundException();

            return default(Entity);
        }

        public IEnumerable<Entity> ReadAll()
        {
            return new Entity[0];
        }
    }
}
