using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDictionary.Core.Repository;
using TheDictionary.Models.Entities;

namespace TheDictionary.Repository.Repositories.Abstracts
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
    }
}
