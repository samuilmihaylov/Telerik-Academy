namespace _07.Sum_of_5_Numbers
{
    using System;

    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            int result = 0;

            for (int index = 1; index <= 5; index++)

            {             
                int inputNumber = int.Parse(Console.ReadLine());
           
                result = result + inputNumber;          
            }

            Console.WriteLine(result);
        }
    }
}
