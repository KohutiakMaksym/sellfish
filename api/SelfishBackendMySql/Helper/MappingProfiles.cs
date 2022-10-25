using AutoMapper;
using AzureContext;
using SelfishBackendMySql.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfishBackendMySql.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Fish, FishDTO>();
            CreateMap<FishDTO, Fish>();
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
            CreateMap<CartToFish, CartToFishDTO>();
            CreateMap<CartToFishDTO, CartToFish>();
            CreateMap<LocationDTO, Location>();
            CreateMap<Location, LocationDTO>();


            CreateMap<Cart, CartDTO>();
            CreateMap<CartDTO, Cart>();
            CreateMap<Comment, CommentDTO>();
            CreateMap<CommentDTO, Comment>();


            //test



        }
    }
}
