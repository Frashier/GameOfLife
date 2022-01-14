using System.Collections.Generic;
using System.Linq;

namespace GameOfLife
{
    public class Cell
    {
        public bool IsAlive;
        private bool WillBeAlive;

        public readonly List<Cell> NeighbouringCells = new List<Cell>();

        /// <summary>
        /// Determine next state of the cell according state of neighbouring cells
        /// </summary>
        public void DetermineNextState()
        {
            // Count alive neighbours
            int LiveNeighbours = NeighbouringCells.Where(x => x.IsAlive).Count();

            // If cell is alive, then will stay alive if has 2 or 3 alive neighbours
            if (IsAlive)
            {
                WillBeAlive = LiveNeighbours == 2 || LiveNeighbours == 3;
                return;
            }

            // If is not alive, then will become alive if it has 3 alive neighbours
            WillBeAlive =  LiveNeighbours == 3;
        }
        /// <summary>
        /// Change cell's state to the next one
        /// </summary>
        public void Advance()
        {
            IsAlive = WillBeAlive;
        }
    }
}
