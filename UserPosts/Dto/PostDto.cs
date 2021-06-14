using System.Text.Json.Serialization;

namespace UserPosts.Models
{
    public class PostDto
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("UserId")]
        public int UserId { get; set; }

        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Body")]
        public string Body { get; set; }
    }
}
