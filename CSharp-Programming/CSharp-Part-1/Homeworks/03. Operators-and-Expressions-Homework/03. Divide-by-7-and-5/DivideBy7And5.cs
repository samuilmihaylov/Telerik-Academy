namespace _03.Divide_by_7_and_5
{
    using System;

    class DivideBy7And5
    {
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            if (inputNumber % 5 == 0 && inputNumber % 7 == 0)
            {
                Console.WriteLine("true {0}", inputNumber);
            }
            else
            {
                Console.WriteLine("false {0}", inputNumber);
            }
        }
    }
}
