using Newtonsoft.Json;

namespace Gb.Application.Models
{
    public sealed record ErrorModel
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; }

        public required string Message { get; set; }
    }
}