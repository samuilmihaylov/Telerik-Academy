namespace CohesionAndCoupling
{
    using System;

    using CohesionAndCoupling.Models;

    public class UtilsExamples
    {
        public static void Main()
        {
            FileExtensionExamples();
            Console.WriteLine("-----------------");

            FigureCalculation2DExamples();
            Console.WriteLine("-----------------");

            FigureCalculations3DExamples();
        }

        private static void FileExtensionExamples()
        {
            Console.WriteLine(FileExtensions.GetFileExtension("example"));
            Console.WriteLine(FileExtensions.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtensions.GetFileNameWithoutExtension("example.new.pdf"));
        }

        private static void FigureCalculation2DExamples()
        {
            var distance = FigureCalculations2D.CalculateDistance2D(1, -2, 3, 4);
            Console.WriteLine("Distance in the 2D space = {0:f2}", distance);

            var figureWidth = 3;
            var figureHeight = 4;

            var figure2D = new Figure(figureWidth, figureHeight);
            var diagonal = FigureCalculations2D.CalculateDiagonal2D(figure2D);

            Console.WriteLine("Diagonal XY = {0:f2}", diagonal);
        }

        private static void FigureCalculations3DExamples()
        {
            var distance = FigureCalculations3D.CalculateDistance3D(5, 2, -1, 3, -6, 4);
            Console.WriteLine("Distance in the 3D space = {0:f2}", distance);

            var figureWidth = 3;
            var figureHeight = 4;
            var figureDepth = 5;

            var figure3D = new Figure3D(figureHeight, figureWidth, figureDepth);
            var volume = FigureCalculations3D.CalculateVolume(figure3D);
            var diagonal = FigureCalculations3D.CalculateDiagonal3D(figure3D);

            Console.WriteLine("Volume = {0:f2}", volume);
            Console.WriteLine("Diagonal XYZ = {0:f2}", diagonal);
        }
    }
}
