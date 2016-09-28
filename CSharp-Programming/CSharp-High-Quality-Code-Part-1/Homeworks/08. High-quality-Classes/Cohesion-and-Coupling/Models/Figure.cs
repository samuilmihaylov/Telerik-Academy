namespace CohesionAndCoupling.Models
{
    using System;

    using CohesionAndCoupling.Contracts;

    public class Figure : IFigure
    {
        private double height;
        private double width;

        public Figure(double height, double width)
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
                    throw new ArgumentException("Height cannot be zero or a negative number.");
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
                    throw new ArgumentException("Width cannot be zero or a negative number.");
                }

                this.width = value;
            }
        }
    }
}
