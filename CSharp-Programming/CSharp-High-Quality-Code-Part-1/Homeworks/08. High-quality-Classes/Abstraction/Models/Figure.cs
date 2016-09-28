namespace Abstraction.Models
{
    using System;

    using Abstraction.Contracts;

    public abstract class Figure : IFigure
    {
        public abstract double CalcPerimeter();

        public abstract double CalcSurface();
        
        public override string ToString()
        {
            var output = string.Format(
                "I am a {2}. My perimeter is {0:f2}. My surface is {1:f2}.", 
                this.CalcPerimeter(),
                this.CalcSurface(),
                this.GetType().Name);

            return output;
        }
    }
}
