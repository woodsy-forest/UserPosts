using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserPosts.Models;

namespace UserPosts.Mapping
{
    public class UserMapping
    {
        public UserPostDto Map(UserPost user)
        {
            var userPostDto = new UserPostDto();
            userPostDto.Id = user.id;
            userPostDto.Name = user.name;
            userPostDto.Username = user.username;
            userPostDto.Email = user.email;
            var addressDto = new AddressDto();
            addressDto.Street = user.address.street;
            addressDto.Suite = user.address.suite;
            addressDto.City = user.address.city;
            addressDto.Zipcode = user.address.zipcode;
            var geoDto = new GeoDto();
            geoDto.Lat = user.address.geo.lat;
            geoDto.Lng = user.address.geo.lng;
            addressDto.Geo = geoDto;
            userPostDto.Address = addressDto;
            userPostDto.Phone = user.phone;
            userPostDto.Website = user.website;
            var companyDto = new CompanyDto();
            companyDto.Name = user.company.name;
            companyDto.CatchPhrase = user.company.catchPhrase;
            companyDto.Bs = user.company.bs;
            userPostDto.Company = companyDto;

            foreach(var post in user.posts)
            {
                var postDto = new PostDto();
                postDto.id = post.id;
                postDto.userId = post.userId;
                postDto.title = post.title;
                postDto.body = post.body;

                userPostDto.Posts.Add(postDto);
            }

            return userPostDto;
        }
    }
}
