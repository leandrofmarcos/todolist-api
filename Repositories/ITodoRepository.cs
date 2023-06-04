using System.Collections.Generic;
using TodoListApi.Models;

namespace TodoListApi.Repositories
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();
        Todo GetById(int id);
        void Add(Todo todo);
        void Update(Todo todo);
        void Remove(Todo todo);
    }
}
