﻿using Microsoft.AspNetCore.Mvc;
using ToDoListModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/<ToDoListController>
        [HttpGet]
        public IEnumerable<ToDoTask> Get()
        {
            return ToDoTask.ReadAll();

        }

        // GET api/<ToDoListController>/5
        [HttpGet("{id}")]
        public ToDoTask Get(int id)
        {
            return ToDoTask.Read(id);
        }

        // POST api/<ToDoListController>
        [HttpPost]
        public void Post([FromBody] string description)
        {
            ToDoTask newTask = new(description);
            newTask.Create();
        }

        // PUT api/<ToDoListController>/5
        [HttpPut("{idToFinish}")]
        public void Put(int idToFinish)
        {
            ToDoTask FinishTask = ToDoTask.Read(idToFinish);
            FinishTask.FinishTask();
        }

        // DELETE api/<ToDoListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ToDoTask deleteTask = ToDoTask.Read(id);
            deleteTask.Delete();
        }
    }
}
