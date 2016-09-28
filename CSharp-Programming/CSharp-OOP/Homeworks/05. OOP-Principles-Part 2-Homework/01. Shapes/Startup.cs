namespace _01.Shapes
{
    using Models;
    using System;
    using System.Collections.Generic;

    class Startup
    {
        static void Main(string[] args)
        {

            var shapeList = new List<Shape>
            {
                new Rectangle(15.6, 19.5),
                new Triangle(146.43, 943.2),
                new Square(2),
                new Rectangle(78.21, 889.5),
                new Triangle(112.43, 435.2),
                new Square(56.543)
            };

            foreach (var shape in shapeList)
            {
                Console.WriteLine("|{0}| with surface equal to: {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}

