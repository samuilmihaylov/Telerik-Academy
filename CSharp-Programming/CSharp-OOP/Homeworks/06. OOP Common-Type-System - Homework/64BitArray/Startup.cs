namespace _64BitArray
{
    using Models;
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(new string('*', 100));
            Console.WriteLine();

            var array = new BitArray64(1245435435121231231);
            Console.WriteLine("Binary code of the number {0} is: {1} ",array.Number, array.ToString());

            Console.WriteLine("First bit = {0}", array[0]);
            Console.WriteLine("Last bit = {0}", array[63]);

            Console.WriteLine(array[0] == array[63]);

            Console.WriteLine();
            Console.WriteLine(new string('*', 100));
            Console.WriteLine();

            Console.WriteLine("Testing Enumerator: ");

            foreach (var bit in array)
            {
                Console.Write(bit + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine(new string('*', 100));
            Console.WriteLine();

            Console.WriteLine("Testing Equals(): ");

            var firstArray = new BitArray64(55667788997);
            var secondArray = new BitArray64(55667788994);
            var thirdArray = new BitArray64(55667788994);

            Console.WriteLine(firstArray.Equals(secondArray));
            Console.WriteLine(secondArray.Equals(thirdArray));
        }
    }
}
