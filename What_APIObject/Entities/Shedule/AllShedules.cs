using Newtonsoft.Json;

namespace What_APIObject.Entities.Shedule
{
    public class ShedulesAll
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("studentGroupId")]
        public int StudentGroupId { get; set; }
        [JsonProperty("eventStart")]
        public DateTime EventStart { get; set; }
        [JsonProperty("eventFinish")]
        public DateTime EventFinish { get; set; }
        [JsonProperty("pattern")]
        public int Pattern { get; set; }
        [JsonProperty("events")]
        public object? Events { get; set; }
        [JsonProperty("storage")]
        public long Storage { get; set; }
    }
}
