using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class DeterminingThread
    {
        private int ThreadNumber;
        static public Cell[,] Cells;
        static public int NumberOfThreads;

        public DeterminingThread(int threadNumber)
        {
            ThreadNumber = threadNumber;
        }

        public void DetermineNextState()
        {
            for (int row = ThreadNumber; row < Cells.GetLength(0); row += NumberOfThreads)
            {
                for (int column = 0; column < Cells.GetLength(1); column++)
                {
                    Cells[row, column].DetermineNextState();
                }
            }
        }

        public void Advance()
        {
            for (int row = ThreadNumber; row < Cells.GetLength(0); row += NumberOfThreads)
            {
                for (int column = 0; column < Cells.GetLength(1); column++)
                {
                    Cells[row, column].Advance();
                }
            }
        }
    }
}
