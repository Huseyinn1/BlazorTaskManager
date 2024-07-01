using EntitesTask = TaskManager.Domain.Entities;

namespace TaskManager.Application.Interfaces
{
    public interface ITaskRepository
    {

        // Task C# içindeki Task ile isim çakışması yaşadı bende Değişken oluşturup kullandım
        Task AddAsync(EntitesTask.Task task);

        Task<List<EntitesTask.Task>> GetAllAsync();

        Task<EntitesTask.Task?> GetByIdAsync(int id);

        Task UpdateAsync(EntitesTask.Task task);

        Task DeleteByIdAsync(int id);
    }
}
