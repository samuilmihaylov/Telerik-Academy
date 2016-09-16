namespace MobilePhoneDevice
{
    using System;

    public class Display
    {
        private int height;
        private int width;
        private string numbersOfColors;

        public Display(int width, int height, string numbersOfColors)
        {
            this.Width = width;
            this.Height = height;
            this.NumberOfColors = numbersOfColors;
        }

        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be bigger than 0");
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be bigger than 0");
                }

                this.height = value;
            }
        }

        public string NumberOfColors
        {
            get
            {
                return this.numbersOfColors;
            }
            set
            {
                this.numbersOfColors = value;
            }
        }
    }
}
