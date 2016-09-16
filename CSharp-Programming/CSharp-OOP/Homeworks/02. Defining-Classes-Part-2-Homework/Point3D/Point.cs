namespace Point3D
{
    using System;
    using System.Text;

    public struct Point
    {
        public static readonly Point startPointO = new Point(0, 0, 0);

        private double x;
        private double y;
        private double z;

        // Constructor

        public Point(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        // Properties for X, Y, Z and startPointO

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public double Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point returnStartPoint
        {
            get
            {
                return startPointO;
            }
        }

        // Methods

        public override string ToString()
        {
            return $"{this.X}, {this.Y}, {this.Z}";
        }

        public static Point Parse(string input) //method for parsing the 3dPoints from the saved txt file
        {
            StringBuilder coordinates = new StringBuilder();
            double[] xyz = new double[3];
            int xyzIndex = 0;

            // input is the "nextPointTxt" from the txt file 

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.'))
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[xyzIndex] = coord;
                    xyzIndex++;
                    coordinates.Clear();
                }
            }

            return new Point(xyz[0], xyz[1], xyz[2]);
        }
    }
}
