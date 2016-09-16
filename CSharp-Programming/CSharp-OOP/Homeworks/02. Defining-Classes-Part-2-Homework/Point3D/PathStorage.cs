namespace Point3D
{
    using System.IO;

    public static class PathStorage
    {
        public static void SavePath(Path path, string pathName)
        {
            using (StreamWriter sw = new StreamWriter("..//..//path" + pathName + ".txt"))
            {
                for (int i = 0; i < path.PointList.Count; i++)
                {
                    sw.WriteLine(path.PointList[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();

            using (StreamReader sr = new StreamReader(filePath))
            {
               while(sr.EndOfStream == false)
                {
                    string nextPointTxt = sr.ReadLine();
                    Point nextPoint = Point.Parse(nextPointTxt);
                    path.AddPoint(nextPoint);
                }
            }
            return path;
        }
    }
}
