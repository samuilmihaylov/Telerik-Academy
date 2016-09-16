namespace AnimalHierarchy.Models
{
    using System;
    using Enumerations;

    public class Frog : Animal
    {
        public Frog(int age, string name, GenderType gender) : base(age, name, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Kwak Kwak..");
        }
    }
}
