using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Zoo
{
    public abstract class Animal
    {
        private string name;

        protected Animal(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
    }
}
