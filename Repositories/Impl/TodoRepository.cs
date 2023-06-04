using System.Collections.Generic;
using System.Linq;
using TodoListApi.Db;
using TodoListApi.Models;

namespace TodoListApi.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public IEnumerable<Todo> GetAll()
        {
            return _context.Todos.ToList();
        }

        public Todo GetById(int id)
        {
            return _context.Todos.FirstOrDefault(t => t.Id == id);
        }

        public void Add(Todo todo)
        {
            _context.Todos.Add(todo);
            _context.SaveChanges();
        }

        public void Update(Todo todo)
        {
            _context.Todos.Update(todo);
            _context.SaveChanges();
        }

        public void Remove(Todo todo)
        {
            _context.Todos.Remove(todo);
            _context.SaveChanges();
        }
    }
}
