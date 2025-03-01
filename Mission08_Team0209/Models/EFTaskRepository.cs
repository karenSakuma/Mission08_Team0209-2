namespace Mission08_Team0209.Models;

public class EfTaskRepository : ITaskRepository
{
    private TaskCollectionContext _context;

    public EfTaskRepository(TaskCollectionContext temp)
    {
        _context = temp;
    }
    public List<Task> Tasks => _context.Tasks.ToList();

    public Task? GetTaskById(int id)
    {
        return _context.Tasks.FirstOrDefault(t => t.TaskId == id);
    }

    public List<Category> GetCategories()
    {
        return _context.Categories.ToList();
    }

    //add task 
    public void AddTask(Task task)
    {
        _context.Add(task);
        _context.SaveChanges();
    }

    //edit task
    public void UpdateTask(Task task)
    {
        _context.Update(task);
        _context.SaveChanges();
    }

    //delete task 
    public void DeleteTask(Task task)
    {
        _context.Remove(task);
        _context.SaveChanges();
    }
}