namespace CohesionAndCoupling
{
    using System;

    using CohesionAndCoupling.Contracts;

    public class FigureCalculations3D
    {
        public static double CalculateDistance3D(
            double pointOneX, 
            double pointOneY, 
            double pointOneZ,
            double pointTwoX, 
            double pointTwoY, 
            double pointTwoZ)
        {
            double powerXDistance = (pointTwoX - pointOneX) * (pointTwoX - pointOneX);
            double powerYDistance = (pointTwoY - pointOneY) * (pointTwoY - pointOneY);
            double powerZDistance = (pointTwoZ - pointOneZ) * (pointTwoZ - pointOneZ);

            double distance = Math.Sqrt(powerXDistance + powerYDistance + powerZDistance);
            return distance;
        }

        public static double CalculateVolume(I3DFigure figure)
        {
            double volume = figure.Width * figure.Height * figure.Depth;

            return volume;
        }

        public static double CalculateDiagonal3D(I3DFigure figure)
        {
            double distance = CalculateDistance3D(0, 0, 0, figure.Width, figure.Height, figure.Depth);

            return distance;
        }
    }
}
