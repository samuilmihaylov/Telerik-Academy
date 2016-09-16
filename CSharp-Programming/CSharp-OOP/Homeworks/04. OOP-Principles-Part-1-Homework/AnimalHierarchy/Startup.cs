using AnimalHierarchy.Enumerations;
using AnimalHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalHierarchy
{
    class Startup
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat(4, "Max", GenderType.Male));
            animals.Add(new Dog(1, "Leo", GenderType.Male));
            animals.Add(new Frog(5, "Mr.Frog", GenderType.Female));
            animals.Add(new Kitten(2, "Kitty"));
            animals.Add(new Tomcat(6, "Tom"));

            var averageSum = (animals.Sum(x => x.Age) / (double)animals.Count);
            Console.WriteLine("Average age of all animals in collection is: {0}", averageSum);
            Console.WriteLine();
        }
    }
}
