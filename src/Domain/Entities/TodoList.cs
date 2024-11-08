using System;

namespace CleanTemplateProject.Domain.Entities;
public class TodoList
{
    public int ID { get; set; }
    public string? Title { get; set; }
    public string? UserName { get; set; }
    public int UserID { get; set; }
    public DateTime Created_Date { get; set; }
    public List<TodoItem>? Items { get; set; } = new();

}
