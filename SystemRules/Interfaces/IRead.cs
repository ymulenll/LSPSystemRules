﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRead<out T>
        where T : Entity
    {
        T ReadOne(int id);

        IEnumerable<T> ReadAll();
    }
}
