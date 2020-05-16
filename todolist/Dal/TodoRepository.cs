using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist.Models;

namespace todolist.Dal
{
    public class TodoRepository : ITodoRepository
    {
        private AppDBContext _context;

        public TodoRepository(AppDBContext context)
        {
            _context = context;
        }
        public bool CreateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTodo(Todo todo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> GetAll()
        {

            var result = _context.Todos.ToList();
            return result;
            //throw new NotImplementedException();
        }

        public Todo GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateTodo(Todo todo)
        {
            throw new NotImplementedException();
        }
    }
}
