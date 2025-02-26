using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Mission08_Team0209.Models;

public class Task
{
    [Key][Required]
    public int TaskId { get; set; }
    
    [Required] public string TaskName { get; set; }
    
    public string? DueDate { get; set; }
    
    //quadrant
    [Required] public int QuandrantNumber { get; set; }
    
    //creating a foreign key relationship for category to access category
    [ForeignKey("CategoryId")]
    public int CategoryId { get; set; }
    public Category? Category{ get; set; }
    
    
    public bool IsCompleted { get; set;  }
    
}