using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheDictionary.Core.Entities;

namespace TheDictionary.Core.Repository
{
    public interface IRepository<TEntity, TId> where TEntity : Entity<TId> , new() // new : entity adında bir veritabanı tablomuz olmadığı için
                                                                                   // bunun önüne geçebilmemiz için new yazmamız gerekiyor
    {
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity? GetById(TId id);
        List<TEntity> GetAll();
    }
}
