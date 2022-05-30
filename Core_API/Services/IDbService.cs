using System.Collections.Generic;
namespace Core_API.Services
{
    public interface IDbService<TEntity, in TPk> where TEntity : class
    {
        IEnumerable<TEntity> Get();
        TEntity Get(TPk id);
        TEntity Create(TEntity entity);
        TEntity Update(TPk id,TEntity entity);
        TEntity Delete(TPk id);
    }
}
