using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using todolist.Dal;
using todolist.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todolist.Api
{
 //   [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private ITodoRepository _repository;
        public TodoController(ITodoRepository repository)
        {
            _repository = repository;
        }
        // GET: api/<controller>
        [HttpGet]
        public  IActionResult GetAll()
        {
           var result = _repository.GetAll();
            return Ok(result);
           // return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpGet]
        public IActionResult Add(int id)
        {
            var a = id;
            return Ok("sip");
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
