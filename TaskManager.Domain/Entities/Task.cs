using System;
using System.ComponentModel.DataAnnotations;
using TaskManager.Domain.Enums;

namespace TaskManager.Domain.Entities
{
    public class Task
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Details are required")]
        public string? Details { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Author name must be between 3 and 50 characters")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "Created date is required")]
        public DateTime? CreatedDate { get; set; }

        [Required(ErrorMessage = "Task priority is required")]
        public TaskPriority TaskPriority { get; set; }

        // public bool IsCompleted { get; set; }
    }
}
