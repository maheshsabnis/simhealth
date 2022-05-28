using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore_DbFirst.Models;

namespace EFCore_DbFirst.DataAccessServices
{
    /// <summary>
    /// Multi-Type Generic Interface
    /// TEntity: The Type that will be used for ENtity Classes e.g. Department, Employee
    /// The 'in' represent an inout parameter for method defined in the interface
    /// Pk the Primary Key whihc may ne interger, string
    /// We are specifying 'Constraints' as 'TEntity' alwys MUST be class
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPk"></typeparam>
    public interface IDataAccess<TEntity, in TPk> where TEntity:EntityBase
    {
        IEnumerable<TEntity> Get(); // return Collection
        TEntity Get(TPk id); // Return SIngle Object based on id
        TEntity Create(TEntity entity); // create new entity and return newly created entity
        TEntity Update(TPk id, TEntity entity); // Update entity based on Primary key
        TEntity Delete(TPk id); // Delete an entity based on primary key
    }
}
