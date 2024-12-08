using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDictionary.Models.Posts;

public sealed record CreatePostRequestDto(string Title, string Content);
