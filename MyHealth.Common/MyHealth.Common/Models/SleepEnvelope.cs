using Newtonsoft.Json;
using System;

namespace MyHealth.Common.Models
{
    public class SleepEnvelope
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public Sleep Sleep { get; set; }
        public DateTime Date { get; set; }
        public string DocumentType { get; set; }
    }
}
