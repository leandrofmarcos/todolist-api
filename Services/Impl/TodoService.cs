using System;
using System.Collections.Generic;
using TodoListApi.Models;
using TodoListApi.Repositories;

namespace TodoListApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public IEnumerable<Todo> GetAllTodos()
        {
            return _todoRepository.GetAll();
        }

        public Todo GetTodoById(int id)
        {
            return _todoRepository.GetById(id);
        }

        public void AddTodo(Todo todo)
        {
            _todoRepository.Add(todo);
        }

        public void UpdateTodoDescription(int id, string description)
        {
            var todo = _todoRepository.GetById(id);
            if (todo != null)
            {
                todo.EditDescription(description);
                _todoRepository.Update(todo);
            }
        }

        public void MarkTodoAsCompleted(int id)
        {
            var todo = _todoRepository.GetById(id);
            if (todo != null)
            {
                todo.MarkAsCompleted();
                _todoRepository.Update(todo);
            }
        }

        public void MarkTodoAsNotCompleted(int id)
        {
            var todo = _todoRepository.GetById(id);
            if (todo != null)
            {
                todo.MarkAsNotCompleted();
                _todoRepository.Update(todo);
            }
        }

        public void RemoveTodo(int id)
        {
            var todo = _todoRepository.GetById(id);
            if (todo != null)
            {
                _todoRepository.Remove(todo);
            }
        }
    }
}
