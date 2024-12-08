using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDictionary.Models.Entities;
using TheDictionary.Models.Posts;

namespace TheDictionary.Service.Mappings
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<CreatePostRequestDto, Post>();
            CreateMap<Post, PostResponseDto>();
        }
    }
}
