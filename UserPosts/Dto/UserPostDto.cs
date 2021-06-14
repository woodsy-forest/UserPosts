using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace UserPosts.Models
{
    public class UserPostDto
    {
        public UserPostDto()
        {
            Posts = new List<PostDto>();
        }
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("UserName")]
        public string UserName { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("Address")]
        public AddressDto Address { get; set; }

        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [JsonPropertyName("Website")]
        public string Website { get; set; }

        [JsonPropertyName("Company")]
        public CompanyDto Company { get; set; }

        [JsonPropertyName("Posts")]
        public List<PostDto> Posts { get; set; }
    }
}
