using System;

namespace TodoListApi.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public void MarkAsNotCompleted()
        {
            IsCompleted = false;
        }

        public void EditDescription(string description)
        {
            Description = description;
        }
    }
}
