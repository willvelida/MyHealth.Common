using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHealth.Common.Models
{
    public class WeightEnvelope
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public Weight Weight { get; set; }
        public string DocumentType { get; set; }
    }
}
