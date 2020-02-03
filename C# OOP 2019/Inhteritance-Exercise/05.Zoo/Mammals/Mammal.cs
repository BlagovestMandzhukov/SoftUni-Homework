using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Zoo.Mammals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name)
            : base(name)
        {
        }
    }
}
