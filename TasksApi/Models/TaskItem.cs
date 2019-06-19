using System;

namespace TasksApi.Models
{
    public class TaskItem {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public TaskList TaskList { get; set; }
    }
}