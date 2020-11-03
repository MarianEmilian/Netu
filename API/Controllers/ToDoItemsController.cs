using System;
using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/todolist")]
    public class ToDoItemsController : ControllerBase
    {
        public IRepository<ToDoItem> _repository { get; }

        public ToDoItemsController(IRepository<ToDoItem> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ToDoItem>> Get()
        {
            return _repository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<ToDoItem> Get(int id)
        {
            return this._repository.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody] ToDoItem todo)
        {
            _repository.Create(todo);
        }

        [HttpPut]
        public void Put([FromBody] ToDoItem todo)
        {
            _repository.Update(todo);
        }
    }
}
