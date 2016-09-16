namespace _01.Shapes.Models
{
    class Square : Shape
    {
        public Square(double width) : base(width, width)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }
    }
}
