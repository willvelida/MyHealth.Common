using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealth.Common.Models
{
    public class WeightExercise
    {
        public string Name { get; set; }
        public double WeightInKg { get; set; }
        public int Reps { get; set; }
        public string Notes { get; set; }
    }
}
