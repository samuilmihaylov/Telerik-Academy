namespace CohesionAndCoupling
{
    using System;

    using CohesionAndCoupling.Contracts;

    public class FigureCalculations2D
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double powerXDistance = (x2 - x1) * (x2 - x1);
            double powerYDistance = (y2 - y1) * (y2 - y1);

            double distance = Math.Sqrt(powerXDistance + powerYDistance);

            return distance;
        }

        public static double CalculateDiagonal2D(IFigure figure)
        {
            double distance = CalculateDistance2D(0, 0, figure.Width, figure.Height);

            return distance;
        }
    }
}
