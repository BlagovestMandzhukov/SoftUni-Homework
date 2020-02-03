using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Zoo.Reptiles
{
    public abstract class Reptile : Animal
    {
        protected Reptile(string name)
            : base(name)
        {
        }
    }
}
