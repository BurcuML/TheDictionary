using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDictionary.Core.Entities
{
    //repository direkt veritabanı nesnesiyle, servis de direkt dtolarla çalışıyoruz, repository ve servis arasındaki en büyük farklardan birisi budur
    public abstract class Entity<TId>  //abstract çünkü soyut bir sınıf oluşturuyoruz soyut olarak kullanacağız
    {
        public TId id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
