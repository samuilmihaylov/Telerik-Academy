namespace PersonClass
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        static void Main(string[] args)
        {
            var personWithAge = new Person("Gosho",20);
            var personWithoutAge = new Person("Pesho", null);

            Console.WriteLine(personWithAge);
            Console.WriteLine();
            Console.WriteLine(new string('*', 40));
            Console.WriteLine();
            Console.WriteLine(personWithoutAge);
            Console.WriteLine();
        }
    }
}
