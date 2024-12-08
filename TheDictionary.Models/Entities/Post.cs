using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDictionary.Core.Entities;

namespace TheDictionary.Models.Entities
{
    public sealed class Post : Entity<Guid> //sealed yazıyoruz çünkü başka bir classa miras vermemize gerek yok
    {
        public string Content { get; set; }
        public string Title { get; set; }
    }
}
