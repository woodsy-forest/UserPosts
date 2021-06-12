using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using UserPosts.Models;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;

namespace UserPosts.Services
{
    public class UserService
    {
        static readonly HttpClient client = new HttpClient();
        public string _url = "";
        public UserService(string url)
        {
            _url = url;
        }

        public async Task<List<UserPost>> GetUserPosts()
        {
            var res = await client.GetAsync(_url + "users");
            string JSONres = res.Content.ReadAsStringAsync().Result;
            List<UserPost> userPosts = JsonSerializer.Deserialize<List<UserPost>>(JSONres);

            PostService postService = new PostService(_url);
            List<Post> posts = await postService.GetPosts();

            foreach (var user in userPosts)
            {
                user.posts.AddRange(posts.Where(p => p.userId == user.id));
            }

            return userPosts;

        }

        public async Task<UserPost> GetUser(int id)
        {
            List<UserPost> userPosts = await GetUserPosts();

            return userPosts.Where(u => u.id == id).FirstOrDefault();

        }

    }
}
