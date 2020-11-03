using API.Data;
using System.Collections.Generic;
using System.Linq;

namespace API
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public Repository(DataContext context)
        {
            _context = context;
        }

        public DataContext _context { get; }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}