using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDictionary.Core.Repository;
using TheDictionary.Models.Entities;
using TheDictionary.Repository.Contexts;

namespace TheDictionary.Repository.Repositories.Concretes
{
    public class EfPostRepository : EfRepositoryBase<BaseDbContext, Post, Guid>
    {
        public EfPostRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
