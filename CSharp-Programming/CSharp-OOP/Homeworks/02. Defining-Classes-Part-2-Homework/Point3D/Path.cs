namespace Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        // Fields

        private List<Point> pointList;

        // Constructor

        public Path()
        {
            this.pointList = new List<Point>();
        }

        // Properties 

        public List<Point> PointList
        {
            get { return this.pointList; }
            set { this.pointList = value; }
        }
        
        // Methods : Add and Remove point

        public void AddPoint(Point point)
        {
            this.pointList.Add(point);
        }

        public void RemovePoint(Point point)
        {
            this.pointList.Remove(point);
        }
    }
}
