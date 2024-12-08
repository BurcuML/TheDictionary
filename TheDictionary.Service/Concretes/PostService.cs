using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDictionary.Core.Entities;
using TheDictionary.Models.Entities;
using TheDictionary.Models.Posts;
using TheDictionary.Repository.Repositories.Abstracts;
using TheDictionary.Service.Abstracts;

namespace TheDictionary.Service.Concretes
{
    public sealed class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;


        //constructor
        public PostService(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public ReturnModel<PostResponseDto> Add(CreatePostRequestDto dto) //öncelikle dto'yu veritabanı tablosuna çevirmemiz gerekiyor ki veritabanına ekleyebilelim
        {
           Post createdPost = _mapper.Map<Post>(dto);
            createdPost.id = Guid.NewGuid();

            Post post = _postRepository.Add(createdPost);
            PostResponseDto responseDto = _mapper.Map<PostResponseDto>(post);
            return new ReturnModel<PostResponseDto>
            {
                Success = true,
                Status=200,
                Message="Post added",
                Data = responseDto
            };
        }

        public ReturnModel<List<PostResponseDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public ReturnModel<PostResponseDto?> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
