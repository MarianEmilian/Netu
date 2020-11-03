using System.Collections.Generic;

namespace API.Data
{
    public interface IRepository<T> where T: BaseEntity
    {
        
        T GetById(int id);
        IEnumerable<T> GetAll();

        public void Create(T entity);
        public void Update(T entity);
        public void Delete(T entity);

    }
}