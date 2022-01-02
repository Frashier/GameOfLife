using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer Timer;
        long[] RenderTimes;
        int RenderTimesIndex;

        public Form1()
        {
            InitializeComponent();

            // Change threads numberic up and down maximum depending on system/s processor count
            ThreadsNud.Maximum = Environment.ProcessorCount - 1 == 0 ? 1 : Environment.ProcessorCount - 1;

            Timer = new System.Windows.Forms.Timer
            {
                Interval = 100,
                Enabled = false
            };
            Timer.Tick += new EventHandler(timer_Tick);

            Reset();
        }

        // GUI actions that require a board reset
        private void ResetButton_Click_1(object sender, EventArgs e) { Reset(); }
        private void pictureBox1_SizeChanged(object sender, EventArgs e) { Reset(); }
        private void SizeNud_ValueChanged(object sender, EventArgs e) { Reset(); }
        private void DensityNud_ValueChanged(object sender, EventArgs e) { Reset(); }

        /// <summary>
        /// Game board divided into cells
        /// </summary>
        Board Board;

        /// <summary>
        /// Render the GUI
        /// </summary>
        private void Render()
        {
            // Start measuring time
            var watch = System.Diagnostics.Stopwatch.StartNew();

            using (var bmp = new Bitmap(Board.Width, Board.Height))
            using (var gfx = Graphics.FromImage(bmp))
            using (var cellBrush = new SolidBrush(Color.LightGreen))
            {
                gfx.Clear(Color.Black);

                var cellSize = (GridCheckbox.Checked && Board.CellSize > 1) ?
                                new Size(Board.CellSize - 1, Board.CellSize - 1) :
                                new Size(Board.CellSize, Board.CellSize);
                
                for (int col = 0; col < Board.Columns; col++)
                {
                    for (int row = 0; row < Board.Rows; row++)
                    {
                        var cell = Board.Cells[col, row];
                        if (cell.IsAlive)
                        {
                            var cellLocation = new Point(col * Board.CellSize, row * Board.CellSize);
                            var cellRect = new Rectangle(cellLocation, cellSize);
                            gfx.FillRectangle(cellBrush, cellRect);
                        }
                    }
                }
                
                pictureBox1.Image = (Bitmap)bmp.Clone();
            }

            // Calculate average render time
            long elapsedMs = watch.ElapsedMilliseconds;
            RenderTimesIndex = RenderTimesIndex == 9 ? 0 : RenderTimesIndex++;
            RenderTimes[RenderTimesIndex] = elapsedMs;
            long sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += RenderTimes[RenderTimesIndex];
            }
            RenderTimeLabel.Text = ((double) sum / 10).ToString();
        }

        /// <summary>
        /// Method used for resetting the board whenever settings are changed
        /// </summary>
        private void Reset()
        {
            // Reset render times
            RenderTimeLabel.Text = "0";
            RenderTimes = new long[10];
            RenderTimesIndex = 0;

            Board = new Board(
                width: pictureBox1.Width,
                height: pictureBox1.Height,
                cellSize: (int)SizeNud.Value,
                liveDensity: (double)DensityNud.Value / 100,
                numberOfThreads: (int) ThreadsNud.Value
            );

            DeterminingThread.Cells = Board.Cells;
            DeterminingThread.NumberOfThreads = (int)ThreadsNud.Value;
            Render();
        }

        private void RunCheckbox_CheckedChanged(object sender, EventArgs e) { Timer.Enabled = RunCheckbox.Checked; }
        private void DelayNud_ValueChanged(object sender, EventArgs e) { Timer.Interval = (int)DelayNud.Value; }
        private void SizeNud_ValueChanged_1(object sender, EventArgs e) { Reset();  }
        private void timer_Tick(object sender, EventArgs e)
        {
            Board.Advance();
            Render();
        }

        private void ThreadsNud_ValueChanged(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
