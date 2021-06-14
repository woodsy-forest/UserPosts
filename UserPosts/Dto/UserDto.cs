using System.Text.Json.Serialization;

namespace UserPosts.Models
{
    public class UserDto
    {

        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("UserName")]
        public string UserName { get; set; }

        [JsonPropertyName("PostCount")]
        public int PostCount { get; set; }

    }
}
