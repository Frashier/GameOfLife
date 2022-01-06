namespace GameOfLife
{
    class DeterminingThread
    {
        //private int ThreadNumber;
        static public Cell[,] Cells;
        static public int NumberOfThreads;

        public DeterminingThread()
        {
            //ThreadNumber = threadNumber;
        }

        public void DetermineNextState(object data)
        {
            for (int row = (int) data; row < Cells.GetLength(0); row += NumberOfThreads)
            {
                for (int column = 0; column < Cells.GetLength(1); column++)
                {
                    Cells[row, column].DetermineNextState();
                }
            }
        }

        public void Advance(object data)
        {
            for (int row = (int) data; row < Cells.GetLength(0); row += NumberOfThreads)
            {
                for (int column = 0; column < Cells.GetLength(1); column++)
                {
                    Cells[row, column].Advance();
                }
            }
        }
    }
}
