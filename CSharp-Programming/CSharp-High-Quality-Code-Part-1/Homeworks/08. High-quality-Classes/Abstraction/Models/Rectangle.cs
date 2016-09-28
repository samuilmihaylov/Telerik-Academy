namespace Abstraction.Models
{
    using System;

    using Abstraction.Contracts;

    public class Rectangle : Figure, IRectangle
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or less than zero.");
                }

                this.height = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or less than zero.");
                }

                this.width = value;
            }
        }

        public override double CalcPerimeter()
        {
            var perimeter = (2 * this.Height) + (2 * this.Width);

            return perimeter;
        }

        public override double CalcSurface()
        {
            var surface = this.Height * this.Width;

            return surface;
        }
    }
}
