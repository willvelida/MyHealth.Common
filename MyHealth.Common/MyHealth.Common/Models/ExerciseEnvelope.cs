using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealth.Common.Models
{
    public class ExerciseEnvelope
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public List<WeightExercise> WeightExercises { get; set; }
        public CardioExercise CardioExercise { get; set; }
        public string DocumentType { get; set; }
    }
}
