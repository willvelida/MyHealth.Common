using Newtonsoft.Json;
using System;

namespace MyHealth.Common.Models
{
    public class ActivityEnvelope
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public Activity Activity { get; set; }
        public string Date { get; set; }
        public string DocumentType { get; set; }
    }
}
