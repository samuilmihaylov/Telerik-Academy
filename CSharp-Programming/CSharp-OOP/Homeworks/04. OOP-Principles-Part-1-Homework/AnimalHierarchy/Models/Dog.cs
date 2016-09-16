namespace AnimalHierarchy.Models
{
    using System;
    using AnimalHierarchy.Enumerations;

    public class Dog : Animal
    {
        public Dog(int age, string name, GenderType gender) : base(age, name, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Bau Bau..");
        }
    }
}
