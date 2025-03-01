using System.ComponentModel;

namespace Mission08_Team0209.Models;

public interface ITaskRepository
{
    List<Task> Tasks { get; }
    
    Task? GetTaskById(int id); // Retrieve a task by ID
    List<Category> GetCategories(); // Fetch categories
    
    public void AddTask(Task task);
    
    public void UpdateTask(Task task);
    public void DeleteTask(Task task);
}