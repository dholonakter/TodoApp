using CleanTemplateProject.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanTemplateProject.Web.Pages
{
    public class IndexModel : PageModel
    {
        //here i am struggling to create a link from models, for example to have a object and
        //build up logic in functions...
        public TodoList? ListItem;
        public void OnGet()
        {
            if (ListItem != null) {
               // ListItem.Items.Add(new TodoItem { });
              }

        }
        public void OnPost() { }
        public void AddItem(int id) 
        {
        }
    }
}
