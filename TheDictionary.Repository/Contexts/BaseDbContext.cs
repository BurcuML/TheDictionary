using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDictionary.Models.Entities;

namespace TheDictionary.Repository.Contexts
{
    public class BaseDbContext : DbContext
    {
        //constructor
        public BaseDbContext(DbContextOptions opt) : base(opt)
        {
            
        }

        public DbSet<Post> Posts { get; set; }
    }
}
