using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class ToDoItem : BaseEntity
    {
        public string Description { get; set; }

        public DateTime Created { get; set; }

        public bool IsDone { get; set; }

        private ToDoItem()
        {
            Created = DateTime.Now;
            IsDone = false;
        }

        private ToDoItem(int id, string description, DateTime created, bool isDone)
        {
            Id = id;
            Description = description;
            Created = created;
            IsDone = IsDone;

        }

        public static ToDoItem CreateProduct(int id, string Description, DateTime Created, bool IsDone)
        {
            ToDoItem todo = new ToDoItem(id, Description, Created, IsDone);
            return todo;
        }
    }
}
