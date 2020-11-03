using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class ToDoItemRepository : Repository<ToDoItem>
    {
        public ToDoItemRepository(DataContext context) : base(context)
        {

        }

        public IEnumerable<ToDoItem> GetToDosActive()
        {
            var result = _context.ToDoItems.Where(p => p.IsDone == false).ToList();
            return result;
        }

        public IEnumerable<ToDoItem> GetToDosDone()
        {
            var result = _context.ToDoItems.Where(p => p.IsDone == true).ToList();
            return result;
        }

        public void Delete(int id)
        {
            _context.Remove(GetById(id));
            _context.SaveChanges();

        }
    }
}
