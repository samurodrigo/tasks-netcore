using System;
using System.Collections.Generic;

namespace TasksApi.Models{
    public class TaskList{
        public int ID { get; set; }
        public string ListName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}