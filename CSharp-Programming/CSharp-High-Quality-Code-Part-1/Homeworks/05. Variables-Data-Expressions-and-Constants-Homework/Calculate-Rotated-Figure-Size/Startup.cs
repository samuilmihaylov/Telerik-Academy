namespace CalculateRotatedFigureSize
{
    using System;

    /// <summary>
    /// The entry point of the program. 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The main method of the program that creates figure objects and executes manipulations with them.
        /// </summary>
        public static void Main(string[] args)
        {
            var cube = new Rectangle(5, 5);

            Rectangle.GetRotatedRectangleSize(cube, 60);       
        }
    }
}
