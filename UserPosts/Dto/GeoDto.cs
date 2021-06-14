using System.Text.Json.Serialization;

namespace UserPosts.Models
{
    public class GeoDto
    {
        [JsonPropertyName("Lat")]
        public string Lat { get; set; }

        [JsonPropertyName("Lng")]
        public string Lng { get; set; }
    }
}
