using System;
using System.Collections.Generic;
using System.Text;

namespace Teste.Domain.Abstractions
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {

        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById (int Id);    

    }
}
