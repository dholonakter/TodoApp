using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CleanTemplateProject.Domain.Entities;
public class TodoItem
{
    public int TaskID { get; set; }//?
    public string? TaskName { get; set; }
    //public string? Description { get; set; }
    //public DueDate Date { get; set; }
    //public List<string>? Steps { get; set; } this is optional
}
