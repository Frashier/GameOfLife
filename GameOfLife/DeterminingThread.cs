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
        private readonly Cell[,] Cells;

        public DeterminingThread(int threadNumber, Cell[,] cells)
        {
            ThreadNumber = threadNumber;
            Cells = cells;
        }

        public void DetermineNextState()
        {
            for (int row = ThreadNumber; row < Cells.GetLength(0); row += ThreadNumber)
            {
                for (int column = 0; column < Cells.GetLength(1); column++)
                {
                    Cells[row, column].DetermineNextState();
                }
            }
        }
    }
}
