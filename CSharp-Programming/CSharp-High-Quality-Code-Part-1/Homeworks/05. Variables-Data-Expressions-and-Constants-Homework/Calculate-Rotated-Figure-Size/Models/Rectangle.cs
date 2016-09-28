namespace CalculateRotatedFigureSize
{
    using System;

    /// <summary>
    /// Contains the properties and behavior for Rectangle objects.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Property width of the rectangle. 
        /// </summary>
        private double width;

        /// <summary>
        /// Property height of the rectangle. 
        /// </summary>
        private double height;

        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle" /> class with given height and width.
        /// </summary>
        /// <param name="width">Width of the figure. </param>
        /// <param name="height">Height of the figure. </param>
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Rotate a rectangle object.
        /// </summary>
        /// <param name="rectangle"> The rectangle object that has to be rotated. </param>
        /// <param name="angleOfRotation"> The angle of rotation. </param>
        /// <returns> Returns new rotated Rectangle object. </returns>
        public static Rectangle GetRotatedRectangleSize(Rectangle rectangle, double angleOfRotation)
        {
            double angleOfRotationCosinus = Math.Abs(Math.Cos(angleOfRotation));
            double angleOfRotationSinus = Math.Abs(Math.Sin(angleOfRotation));

            double widthOfTheRotatedRectangle = (angleOfRotationSinus * rectangle.width) + (angleOfRotationCosinus * rectangle.height);
            double heightOfTheRotatedRectangle = (angleOfRotationCosinus * rectangle.width) + (angleOfRotationSinus * rectangle.height);

            Rectangle rotatedRectangle = new Rectangle(widthOfTheRotatedRectangle, heightOfTheRotatedRectangle);

            return rotatedRectangle;
        }
    }
}
