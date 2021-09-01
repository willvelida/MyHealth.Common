using Newtonsoft.Json;

namespace MyHealth.Common.Models
{
    public class SleepEnvelope
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public Sleep Sleep { get; set; }
        public string Date { get; set; }
        public string DocumentType { get; set; }
    }
}
