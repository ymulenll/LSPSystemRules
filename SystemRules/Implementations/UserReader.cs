using Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class UserReader : IRead<User>
    {
        public User ReadOne(int id)
        {
            if (id == 0)
                throw new UserNotFoundException();

            return default(User);
        }

        public IEnumerable<User> ReadAll()
        {
            return new User[0];
        }
    }
}
