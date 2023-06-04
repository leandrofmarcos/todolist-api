using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoListApi.Models;
using TodoListApi.Services;

namespace TodoListApi.Controllers
{
    [ApiController]
    [Route("api/todos")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetAllTodos()
        {
            var todos = _todoService.GetAllTodos();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodoById(int id)
        {
            var todo = _todoService.GetTodoById(id);
            if (todo == null)
            {
                return NotFound();
            }
            return Ok(todo);
        }

        [HttpPost]
        public IActionResult AddTodo([FromBody] Todo todo)
        {
            _todoService.AddTodo(todo);
            return CreatedAtAction(nameof(GetTodoById), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}/description")]
        public IActionResult UpdateTodoDescription(int id, [FromBody] string description)
        {
            _todoService.UpdateTodoDescription(id, description);
            return NoContent();
        }

        [HttpPatch("{id}/complete")]
        public IActionResult MarkTodoAsCompleted(int id)
        {
            _todoService.MarkTodoAsCompleted(id);
            return NoContent();
        }

        [HttpPatch("{id}/incomplete")]
        public IActionResult MarkTodoAsNotCompleted(int id)
        {
            _todoService.MarkTodoAsNotCompleted(id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveTodo(int id)
        {
            _todoService.RemoveTodo(id);
            return NoContent();
        }
    }
}
