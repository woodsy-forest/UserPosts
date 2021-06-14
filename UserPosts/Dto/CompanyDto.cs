using System.Text.Json.Serialization;

namespace UserPosts.Models
{
    public class CompanyDto
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("CatchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("Bs")]
        public string Bs { get; set; }
    }
}
