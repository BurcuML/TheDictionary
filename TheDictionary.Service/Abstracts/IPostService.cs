
using TheDictionary.Core.Entities;
using TheDictionary.Models.Posts;

namespace TheDictionary.Service.Abstracts
{
    public interface IPostService
    {
        ReturnModel<PostResponseDto> Add(CreatePostRequestDto dto);
        ReturnModel<List<PostResponseDto>> GetAll();
        ReturnModel<PostResponseDto?> GetById(Guid id);
    }
}
