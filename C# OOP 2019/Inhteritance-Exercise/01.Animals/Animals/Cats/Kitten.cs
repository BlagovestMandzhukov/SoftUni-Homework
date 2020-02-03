using _01.Animals.Genders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Animals.Animals.Cats
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, CatsGender.Female.ToString())
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
