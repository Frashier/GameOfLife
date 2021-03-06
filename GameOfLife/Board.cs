using System;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Board
    {
        public Cell[,] Cells;
        public readonly int CellSize;

        public int Columns {get {return Cells.GetLength(0); }}
        public int Rows {get {return Cells.GetLength(1); }}
        public int Width {get {return Columns * CellSize; }}
        public int Height { get { return Rows * CellSize; } }

        public Board(int width, int height, int cellSize, double liveDensity = .1)
        {
            CellSize = cellSize;
            Cells = new Cell[width / cellSize, height / cellSize];
            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    Cells[x, y] = new Cell();
                }
            }

            ConnectNeighbours();
            RandomizePopulation(liveDensity);
        }

        readonly Random rand = new Random();
        /// <summary>
        /// Randomly assing IsAlive values to all the cells
        /// </summary>
        /// <param name="liveDensity"></param>
        public void RandomizePopulation(double liveDensity)
        {
            foreach (var cell in Cells)
            {
                cell.IsAlive = rand.NextDouble() < liveDensity;
            }     
        }

        /// <summary>
        /// Advance board to next step
        /// </summary>
        public void Advance(int partitioningLevel = 8)
        {
            Parallel.For(0, partitioningLevel, partitionNumber =>
            {
                for (int row = partitionNumber; row < Rows; row += partitioningLevel)
                {
                    for (int col = 0; col < Columns; col++)
                    {
                        Cells[col, row].DetermineNextState();
                    }
                }
            });

            Parallel.For(0, partitioningLevel, partitionNumber =>
            {
                for (int row = partitionNumber; row < Rows; row += partitioningLevel)
                {
                    for (int col = 0; col < Columns; col++)
                    {
                        Cells[col, row].Advance();
                    }
                }
            });
        }

        /// <summary>
        /// Connect all neightbouring cells
        /// </summary>
        private void ConnectNeighbours()
        {
            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    // determine X of left and right cells
                    int xL = (x > 0) ? x - 1 : Columns - 1;
                    int xR = (x < Columns - 1) ? x + 1 : 0;

                    // determine Y of top and bottom cells
                    int yT = (y > 0) ? y - 1 : Rows - 1;
                    int yB = (y < Rows - 1) ? y + 1 : 0;

                    // add the 8 neighbors surrounding this cell
                    Cells[x, y].NeighbouringCells.Add(Cells[xL, yT]);
                    Cells[x, y].NeighbouringCells.Add(Cells[x, yT]);
                    Cells[x, y].NeighbouringCells.Add(Cells[xR, yT]);
                    Cells[x, y].NeighbouringCells.Add(Cells[xL, y]);
                    Cells[x, y].NeighbouringCells.Add(Cells[xR, y]);
                    Cells[x, y].NeighbouringCells.Add(Cells[xL, yB]);
                    Cells[x, y].NeighbouringCells.Add(Cells[x, yB]);
                    Cells[x, y].NeighbouringCells.Add(Cells[xR, yB]);
                }
            }
        }
    }
}
