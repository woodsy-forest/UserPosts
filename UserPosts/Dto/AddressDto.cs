using System.Text.Json.Serialization;

namespace UserPosts.Models
{
    public class AddressDto
    {
        [JsonPropertyName("Street")]
        public string Street { get; set; }

        [JsonPropertyName("Suite")]
        public string Suite { get; set; }

        [JsonPropertyName("City")]
        public string City { get; set; }

        [JsonPropertyName("Zipcode")]
        public string Zipcode { get; set; }

        [JsonPropertyName("Geo")]
        public GeoDto Geo { get; set; }
    }
}
