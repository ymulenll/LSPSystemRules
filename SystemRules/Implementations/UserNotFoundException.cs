﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException()
            : base()
        {

        }

        public UserNotFoundException(string message)
            : base(message)
        {

        }
    }
}
