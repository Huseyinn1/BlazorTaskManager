
using Microsoft.EntityFrameworkCore;
using EntitesTask = TaskManager.Domain.Entities;

namespace TaskManager.Core.Context
{
    public class TaskManagerDbContext : DbContext
    {
        public TaskManagerDbContext(DbContextOptions<TaskManagerDbContext> options) : base(options) 
        { 

        }
        public DbSet<EntitesTask.Task> Tasks { get; set; }


      
    }
}
