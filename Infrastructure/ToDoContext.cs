using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Biscos_Vanessa_ToDoList.Models;


namespace Biscos_Vanessa_ToDoList.Infrastructure
{
    public class ToDoContext : DbContext

    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {

        }

        public DbSet<TodoList> ToDoList { get; set; }
    
    }
}
