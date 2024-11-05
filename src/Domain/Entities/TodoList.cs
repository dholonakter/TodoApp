using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CleanTemplateProject.Domain.Entities;
public class TodoList
{
    //public string? Title { get; set; }
    public int ID { get; set; }//?
    public List<TodoItem>? Items { get; set; } = new();
   


    public TodoList()
    {
        Items = new();
    }
}
