using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using UserPosts.Models;
using UserPosts.Services;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class UserServiceUnitTest
    {
        public string url = "https://jsonplaceholder.typicode.com/";
        public UserServiceUnitTest()
        {
        }

        [TestMethod]
        public void GetPosts()
        {
            PostService postService = new PostService(url);
            var posts = postService.GetPosts().Result;
            Assert.AreEqual(100, posts.Count, "GetPosts: Wrong number of posts.");

        }

        [TestMethod]
        public void GetUserPosts()
        {
            UserService userService = new UserService(url);
            List<UserPost> userPosts = userService.GetUserPosts().Result;
            Assert.AreEqual(10, userPosts.Count, "GetUserPosts: Wrong number of users.");
            Assert.AreEqual(10, userPosts.Where(u => u.username == "Bret").FirstOrDefault().posts.Count, "GetUserPosts: Wrong number of posts.");

        }

        [TestMethod]
        public void GetUser()
        {
            UserService userService = new UserService(url);
            UserPost user = userService.GetUser(1).Result;
            Assert.AreEqual("Leanne Graham", user.name, "GetUser: Wrong name.");
            Assert.AreEqual("Bret", user.username, "GetUser: Wrong name.");
            Assert.AreEqual("1-770-736-8031 x56442", user.phone, "GetUser: Wrong name.");

        }
    }
}
