namespace _01.Shapes.Models
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                if (this.width < 0)
                {
                    throw new ArgumentException("The value of the width can not be negative");
                }
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of the width can not be negative");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                if (this.height < 0)
                {
                    throw new ArgumentException("The value of the height can not be negative");
                }
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of the height can not be negative");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();


    }
}
