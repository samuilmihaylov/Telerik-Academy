using System;
using AnimalHierarchy.Enumerations;

namespace AnimalHierarchy.Models
{
    class Kitten : Cat
    {
        public Kitten(int age, string name, GenderType gender = GenderType.Female) : base(age, name, gender)
        {
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("I am a little kitten.. miauu..");
        }
    }
}
