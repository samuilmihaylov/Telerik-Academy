namespace AnimalHierarchy.Models
{
    using AnimalHierarchy.Enumerations;
    using System;

    public class Cat : Animal
    {
        public Cat(int age, string name, GenderType gender) : base(age, name, gender)
        {

        }

        public override void MakeSound()
        {
           Console.WriteLine("Miau Miau..");
        }
    }
}
