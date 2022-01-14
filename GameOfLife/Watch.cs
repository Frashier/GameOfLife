using System;
using System.Collections.Generic;

namespace GameOfLife
{
    class Watch
    {
        private Queue<long> TimeMeasurements;
        private int MeasurementCount;
        private System.Diagnostics.Stopwatch MyWatch;
        public long LastMeasurement;

        public double Average
        {
            get
            {
                long sum = 0;
                long[] buffer = new long[MeasurementCount];

                TimeMeasurements.CopyTo(buffer, 0);
                for (int i = 0; i < TimeMeasurements.Count; i++)
                {
                    sum += buffer[i];
                }

                return (Math.Round((double)sum / TimeMeasurements.Count, 1));
            }
        }

        public Watch(int measurementCount)
        {
            MeasurementCount = measurementCount;
            TimeMeasurements = new Queue<long>();
        }

        public void Reset()
        {
            TimeMeasurements = new Queue<long>();
        }

        public void Start()
        {
            MyWatch = System.Diagnostics.Stopwatch.StartNew();
        }

        public void StopAndMeasure()
        {
            MyWatch.Stop();
            long elapsedMs = MyWatch.ElapsedMilliseconds;

            if (TimeMeasurements.Count == MeasurementCount)
            {
                TimeMeasurements.Dequeue();
            }
            TimeMeasurements.Enqueue(elapsedMs);

            LastMeasurement = elapsedMs;
        }
    }
}
