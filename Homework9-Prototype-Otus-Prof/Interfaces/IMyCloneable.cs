﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Prototype_Otus_Prof.Interfaces
{
    internal interface IMyCloneable<T> where T : class
    {
        T MyClone();
    }
}
