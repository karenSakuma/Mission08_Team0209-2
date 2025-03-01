using System.ComponentModel;

namespace Mission08_Team0209.Models;

public interface ITaskRepository
{
    List<Task> Tasks { get; }
    List<Category> Categories { get; } // Fetch categories
    
    public void AddTask(Task task);
    
    public void UpdateTask(Task task);
    public void DeleteTask(Task task);
}