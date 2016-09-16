namespace _02.Moon_Gravity
{
    using System;

    class MoonGravity
    {
        static void Main(string[] args)
        {
            double inputWeight = Convert.ToDouble(Console.ReadLine());

            double weightOnMoon = inputWeight * 17 / 100;

            Console.WriteLine(weightOnMoon.ToString("N3"));
        }
    }
}
