using System.Text.Json.Serialization;

namespace UserPosts.Models
{
    public class UserDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public int PostCount { get; set; }

    }
}
