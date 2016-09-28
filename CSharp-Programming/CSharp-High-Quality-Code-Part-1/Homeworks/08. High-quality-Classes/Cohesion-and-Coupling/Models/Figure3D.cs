namespace CohesionAndCoupling.Models
{
    using System;
    using CohesionAndCoupling.Contracts;

    public class Figure3D : Figure, I3DFigure
    {
        private double depth;

        public Figure3D(double height, double width, double depth) : base(height, width)
        {
            this.Depth = depth;
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Depth cannot be zero or a negative number.");
                }

                this.depth = value;
            }
        }
    }
}
