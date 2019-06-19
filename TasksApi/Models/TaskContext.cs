using Microsoft.EntityFrameworkCore;

namespace TasksApi.Models
{
    public class TaskContext : DbContext {
        public TaskContext(DbContextOptions<TaskContext> options)
            :base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<TaskList> TasksList { get; set; }
    }
}