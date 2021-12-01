using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem>? TodoItems { get; set; } = null;

        public TodoContext(DbContextOptions<TodoContext> options): base(options) { }
    }
}