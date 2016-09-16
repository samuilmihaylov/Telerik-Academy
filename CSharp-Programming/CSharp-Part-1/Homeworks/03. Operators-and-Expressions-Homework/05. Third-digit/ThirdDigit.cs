namespace _05.Third_digit
{
    using System;

    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());

            int thirdDigit = ((inputNumber / 100) % 10);
      
            if (thirdDigit == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", thirdDigit);
            }
        }
    }
}
