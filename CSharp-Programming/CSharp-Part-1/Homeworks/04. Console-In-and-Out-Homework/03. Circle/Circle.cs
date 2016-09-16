namespace _03.Circle
{
    using System;

    class Circle
    {
        static void Main(string[] args)
        {
            double inputCircleRadius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(inputCircleRadius, 2);
            double circlePerimeter = 2 * Math.PI * inputCircleRadius;

            Console.WriteLine(circlePerimeter.ToString("F2") + " " + circleArea.ToString("F2"));
        }
    }
}
