using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todolist.Models;

namespace todolist.Dal
{
    public interface ITodoRepository
    {
        List<Todo> GetAll();
        Todo GetById(int Id);    

        bool CreateTodo(Todo todo);
        bool UpdateTodo(Todo todo);
        bool DeleteTodo(Todo todo);
        bool Save();
    }
}
