using AnimalHierarchy.Enumerations;
using AnimalHierarchy.Interfaces;
using System;

namespace AnimalHierarchy.Models
{
    public abstract class Animal : ISound
    {
        // All animals are described by age, name and sex.

        private int age;
        private string name;
        private GenderType gender;

        public Animal(int age, string name, GenderType gender)
        {
            this.Age = age;
            this.Name = name;
            this.Gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be negative value.");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The name can not be empty.");
                }
                this.name = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("I am animal and I make some sound.");
        }
    }
}
