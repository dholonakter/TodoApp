using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CleanTemplateProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanTemplateProject.Infrastructure.Data.Configurations;
public class TodoListConfiguration : IEntityTypeConfiguration<TodoList>
{
    public void Configure(EntityTypeBuilder<TodoList> builder)
    {
        builder
            .Property(t => t.Title)
            .IsRequired();
        builder.HasMany(t => t.Items).WithOne().HasForeignKey(t => t.TodoListId);
    }
}
