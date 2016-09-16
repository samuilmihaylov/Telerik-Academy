namespace _10.Point__Circle__Rectangle
{
    using System;

    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double pointX = Double.Parse(Console.ReadLine());
            double pointY = Double.Parse(Console.ReadLine());

            bool isInsideCircle = Math.Pow((pointX - 1), 2) + Math.Pow((pointY - 1), 2) <= Math.Pow(1.5, 2);

            bool isInsideRectangle = (pointX >= -1) && (pointX <= (-1 + 6)) && (pointY <= 1) && (pointY >= (1 - 2));

            if (isInsideCircle == true && isInsideRectangle == true)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if (isInsideCircle == true && isInsideRectangle == false)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else if (isInsideCircle == false && isInsideRectangle == true)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (isInsideCircle == false && isInsideRectangle == false)
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }
    }
}
