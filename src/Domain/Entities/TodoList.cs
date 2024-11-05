using System;

namespace CleanTemplateProject.Domain.Entities;
public class TodoList
{
    public int ID { get; set; }
    public string? Title { get; set; }
    public List<TodoItem>? Items { get; set; } = new();

}
