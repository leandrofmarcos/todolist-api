using System.Collections.Generic;
using TodoListApi.Models;

namespace TodoListApi.Services
{
    public interface ITodoService
    {
        IEnumerable<Todo> GetAllTodos();
        Todo GetTodoById(int id);
        void AddTodo(Todo todo);
        void UpdateTodoDescription(int id, string description);
        void MarkTodoAsCompleted(int id);
        void MarkTodoAsNotCompleted(int id);
        void RemoveTodo(int id);
    }
}
