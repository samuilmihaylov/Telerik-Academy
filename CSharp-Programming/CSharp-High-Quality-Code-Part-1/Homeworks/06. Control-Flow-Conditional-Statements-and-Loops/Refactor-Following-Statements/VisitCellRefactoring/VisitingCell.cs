namespace RefactorFollowingStatements.VisitCell
{
    public class VisitingCell
    {
        private const int MinX = 0;
        private const int MaxX = 10;
        private const int MinY = 0;
        private const int MaxY = 10;

        private bool[,] matrix = new bool[MaxX, MaxY];

        public void ValidateCell(int x, int y)
        {
            if (this.IsCurrentCellInRange(x, y, this.matrix) &&
                !this.IsCurrentCellVisited(x, y, this.matrix))
            {
                this.VisitCell(x, y, this.matrix);
            }
        }

        public bool IsCurrentCellInRange(int x, int y, bool[,] matrix)
        {
            if ((MinX < x && x < MaxX) &&
               (MinY < y && y < MaxY))
            {
                return true;
            }

            return false;
        }

        public bool IsCurrentCellVisited(int x, int y, bool[,] matrix)
        {
            if (matrix[x, y])
            {
                return true;
            }

            return false;
        }

        private void VisitCell(int x, int y, bool[,] matrix)
        {
            matrix[x, y] = true;
        }
    }
}
