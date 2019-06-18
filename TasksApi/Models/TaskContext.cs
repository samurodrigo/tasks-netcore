using Microsoft.EntityFrameworkCore;

namespace TasksApi.Models
{
    public class TaskContext : DbContext {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskList> TasksList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlite("Data Source=tasks.db");
        }
    }
}