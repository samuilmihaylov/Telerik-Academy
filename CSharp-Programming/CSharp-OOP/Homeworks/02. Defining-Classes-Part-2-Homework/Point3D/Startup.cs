namespace Point3D
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            Path testPath = new Path();

            // Creating points
            Point pointOne = new Point(1, 3, 5);
            Point pointTwo = new Point(2.5, 8.6, -4.3);
            Point pointThree = new Point(-1, -4, 3.5);

            // Adding points in Path.cs (AddPoint method)
            testPath.AddPoint(pointOne);
            testPath.AddPoint(pointTwo);
            testPath.AddPoint(pointThree);

            PathStorage.SavePath(testPath, "initial");

            Path loadedPath = PathStorage.LoadPath(@"../../pathinitial.txt");

            Console.WriteLine("The points from the saved text file are: ");
            Console.WriteLine();
            for (int i = 0; i < loadedPath.PointList.Count; i++)
            {
                Console.WriteLine("Point {0}: {1}", i + 1, loadedPath.PointList[i].ToString());
            }
        }
    }
}
