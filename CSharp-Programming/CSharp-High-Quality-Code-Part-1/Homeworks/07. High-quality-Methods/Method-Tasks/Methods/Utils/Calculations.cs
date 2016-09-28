namespace Methods.Utils
{
    using System;
    using System.Collections.Generic;

    public class Calculations
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive values.");
            }

            var isValidTriangle = CheckIfSideLengthsCanComposeAValidTriangle(sideA, sideB, sideC);

            if (!isValidTriangle)
            {
                throw new ArgumentException($"Triangle with input side values a: {sideA} b: {sideB} and c: {sideC} cannot form a valid triangle.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double triangleArea = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return triangleArea;
        }

        public static string DigitToWord(int number)
        {
            var digitTranslations = new Dictionary<int, string>()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
            };

            string result;
            if (digitTranslations.ContainsKey(number))
            {
                result = digitTranslations[number];
            }
            else
            {
                throw new ArgumentException("The input number does not exist.");
            }

            return result;
        }

        public static int FindMaximumValue(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("No existing elements.");
            }

            var maximimValue = elements[0];
            for (int index = 1; index < elements.Length; index++)
            {
                if (elements[index] > maximimValue)
                {
                    maximimValue = elements[index];
                }
            }

            return maximimValue;
        }

        public static double CalculateDistance(
            double pointOneCoordinateX,
            double pointOneCoordinateY,
            double pointTwoCoordinateX,
            double pointTwoCoordinateY,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = pointOneCoordinateY == pointTwoCoordinateY;
            isVertical = pointOneCoordinateX == pointTwoCoordinateX;

            var distanceX = pointTwoCoordinateX - pointOneCoordinateX;
            var distanceY = pointTwoCoordinateY - pointOneCoordinateY;

            var distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
            return distance;
        }

        private static bool CheckIfSideLengthsCanComposeAValidTriangle(double sideA, double sideB, double sideC)
        {
            var isSideAValid = sideA < (sideB + sideC);
            var isSideBValid = sideB < (sideA + sideC);
            var isSideCValid = sideC < (sideA + sideB);

            var isValidTriangle = isSideAValid && isSideBValid && isSideCValid;

            return isValidTriangle;
        }
    }
}
