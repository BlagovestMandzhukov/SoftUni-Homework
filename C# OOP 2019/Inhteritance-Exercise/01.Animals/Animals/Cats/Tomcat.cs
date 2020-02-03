using _01.Animals.Genders;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Animals.Animals.Cats
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            : base(name, age, CatsGender.Male.ToString())
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
