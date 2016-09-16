namespace _07.Point_in_a_circle
{
    using System;

    class PointInACircle
    {
        static void Main(string[] args)
        {
            double pointX = Double.Parse(Console.ReadLine());
            double pointY = Double.Parse(Console.ReadLine());

            double circleDistance = Math.Sqrt(Math.Pow((pointX), 2) + Math.Pow((pointY), 2));

            bool isInCircle = Math.Pow((pointX - 0), 2) + Math.Pow((pointY - 0), 2) <= Math.Pow(2, 2);

            if (isInCircle)
            {
                Console.WriteLine("yes {0:0.00}", circleDistance);
            }
            else
            {
                Console.WriteLine("no {0:0.00}", circleDistance);
            }
        }
    }
}
