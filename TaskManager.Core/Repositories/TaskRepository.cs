using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Interfaces;
using TaskManager.Core.Context;
using EntitesTask = TaskManager.Domain.Entities;

namespace TaskManager.Core.Repositories
{
    public class TaskRepository : ITaskRepository
    {

        private readonly TaskManagerDbContext context;
        public TaskRepository(IDbContextFactory<TaskManagerDbContext> contextFactory)
        {
            context = contextFactory.CreateDbContext();
            
        }
        // Task C# içindeki Task ile isim çakışması yaşadı bende Değişken oluşturup kullandım.
        public async Task AddAsync(EntitesTask.Task task)
        {
            context.Tasks.Add(task);
            await context.SaveChangesAsync();
        }

  

        public async Task<List<EntitesTask.Task>> GetAllAsync()

        {
            var tasks = await context.Tasks.ToListAsync();
            return tasks;
        }

        public async Task<EntitesTask.Task?> GetByIdAsync(int id)
        {
            var task = await context.Tasks.FirstOrDefaultAsync(x=>x.Id==id);
            return task;
        }

        public async Task UpdateAsync(EntitesTask.Task task)
        {
           context.Entry(task).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
        public async Task DeleteByIdAsync(int id)
        {
            var task = await GetByIdAsync(id);
            if (task is not null)
            {
                context.Tasks.Remove(task);
                await context.SaveChangesAsync();
            }
        }
    }
}
