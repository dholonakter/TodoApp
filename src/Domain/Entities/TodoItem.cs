
using System;
using CleanTemplateProject.Domain.Enums;

namespace CleanTemplateProject.Domain.Entities;
public class TodoItem
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public DateOnly Date { get; set; }
    public List<string>? Steps { get; set; }
    public Priority Priority { get; set; }
    public bool IsCompleted { get; set; }

}
