namespace AnimalHierarchy.Models
{
    using System;
    using AnimalHierarchy.Enumerations;

    public class Tomcat : Cat
    {
        public Tomcat(int age, string name, GenderType gender = GenderType.Male) : base(age, name, gender)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("I am Tomcat and I make MIAU.");
        }
    }
}
