using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todos2019.Models;

namespace Todos2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ToDosContext db;

        public TodosController(ToDosContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ToDo>> Get()
        {
            return db.ToDos.ToList();
        }

        [HttpPost]
        public ActionResult<IEnumerable<ToDo>> Post([FromBody] ToDo todo)
        {
            db.ToDos.Add(todo);
            db.SaveChanges();
            return db.ToDos.ToList();
        }

        [HttpDelete]
        public ActionResult<IEnumerable<ToDo>> Delete([FromBody] ToDo todo)
        {
            db.ToDos.Remove(todo);
            db.SaveChanges();
            return db.ToDos.ToList();
        }
    }
}