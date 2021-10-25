using System;
using System.Collections.Generic;
using Statistics.Entities;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public float average { get; set; }
        public float max { get; set; }
        public float min { get; set; }
        public Stats CalculateStatistics(List<float> numbers) {
            //Implement statistics here

            if (numbers.Count > 0)
            {
                min = numbers.Min();
                max = numbers.Max();
                average = numbers.Count > 0 ? numbers.Average() : float.NaN;
            }
            else
            {
                min = float.NaN;
                max = float.NaN;
                average = float.NaN;
            }
            return new Stats
            {
                min = this.min,
                max = this.max,
                average = this.average
            };
        }
    }
}
