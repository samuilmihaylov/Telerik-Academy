namespace _04.Rectangles
{
    using System;

    class Rectangles
    {
        static void Main(string[] args)
        {
            double rectangleWidth = double.Parse(Console.ReadLine());
            double rectangleHeight = double.Parse(Console.ReadLine());

            double rectangleArea = rectangleWidth * rectangleHeight;
            double rectanglePerimeter = 2 * (rectangleWidth + rectangleHeight);

            Console.WriteLine("{0:0.00} {1:0.00}", rectangleArea, rectanglePerimeter);
        }
    }
}
