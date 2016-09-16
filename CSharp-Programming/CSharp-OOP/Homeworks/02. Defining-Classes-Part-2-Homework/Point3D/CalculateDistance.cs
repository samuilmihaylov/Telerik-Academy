namespace Point3D
{
    using System;

    static class CalculateDistance
    {
        public static double Calculate(Point pointOne, Point pointTwo)
        {
            double distance = 0;

            distance = Math.Sqrt((pointOne.X - pointTwo.X) * (pointOne.X - pointTwo.X) +
                                 (pointOne.Y - pointTwo.Y) * (pointOne.Y - pointTwo.Y) +
                                 (pointOne.Z - pointTwo.Z) * (pointOne.Z - pointTwo.Z));

            return distance;
        }
    }
}
