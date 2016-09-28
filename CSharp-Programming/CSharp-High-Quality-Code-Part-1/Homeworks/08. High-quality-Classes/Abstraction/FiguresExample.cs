namespace Abstraction
{
    using System;

    using Models;

    public class FiguresExample
    {
        public static void Main()
        {
            double circleRadius = 2.5;
            var circle = new Circle(circleRadius);
            Console.WriteLine(circle);

            double rectangleWidth = 3.1;
            double rectangleHeight = 5.1;
            var rectangle = new Rectangle(rectangleWidth, rectangleHeight);

            Console.WriteLine(rectangle);
        }
    }
}
