using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPosts.Mapping;
using UserPosts.Models;
using UserPosts.Services;

namespace UserPosts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public string jsonplaceholderTypicodeUrl = "";
        public UserController(IConfiguration configuration)
        {
            _configuration = configuration;
            jsonplaceholderTypicodeUrl = _configuration["jsonplaceholderTypicodeUrl"];
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            if (id == 0)
                return NotFound();

            UserService userService = new UserService(jsonplaceholderTypicodeUrl);
            UserPost user = await userService.GetUser(id);

            var userMapping = new UserMapping();

            return Ok(userMapping.Map(user));

        }

        [HttpGet()]
        public async Task<IActionResult> GetUsers()
        {

            try
            {
                UserService userService = new UserService(jsonplaceholderTypicodeUrl);
                List<UserPost> users = await userService.GetUserPosts();

                var usersDto = new List<UserDto>();
                foreach(var user in users)
                {
                    var userDto = new UserDto();
                    userDto.Id = user.id;
                    userDto.Name = user.name;
                    userDto.UserName = user.username;
                    userDto.PostCount = user.posts.Count;

                    usersDto.Add(userDto);
                }

                return Ok(usersDto);

            }
            catch (Exception ex)
            {
                //500 - Internal Server Error
                return StatusCode(500, ex.Message);
            }

        }



    }
}
