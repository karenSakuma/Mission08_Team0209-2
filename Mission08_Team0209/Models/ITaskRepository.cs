using System.ComponentModel;

namespace Mission08_Team0209.Models;

public interface ITaskRepository
{
    List<Task> Tasks { get; }
    public void AddTask(Task task);
    
    public void UpdateTask(Task task);
    public void DeleteTask(Task task);
}