using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using UserPosts.Models;
using System.Text.Json;

namespace UserPosts.Services
{
    public class PostService
    {

        static readonly HttpClient client = new HttpClient();
        public string _url = "";
        public PostService(string url)
        {
            _url = url;
        }

        public async Task<List<Post>> GetPosts()
        {
            var res = await client.GetAsync(_url + "posts");
            string JSONres = res.Content.ReadAsStringAsync().Result;
            List<Post> posts = JsonSerializer.Deserialize<List<Post>>(JSONres);
            return posts;
        }
    }
}
