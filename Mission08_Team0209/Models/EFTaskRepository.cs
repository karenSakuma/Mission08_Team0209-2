namespace Mission08_Team0209.Models;

public class EFTaskRepository : ITaskRepository
{
    private TaskCollectionContext _context;

    public EFTaskRepository(TaskCollectionContext temp)
    {
        _context = temp;
    }
    public List<Task> Tasks => _context.Tasks.ToList();

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