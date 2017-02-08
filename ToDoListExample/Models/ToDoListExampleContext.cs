using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoListExample.Models
{
    public class ToDoListExampleContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ToDoListExampleContext() : base("name=ToDoListExampleContext")
        {
        }

        public System.Data.Entity.DbSet<ToDoListExample.Models.task> tasks { get; set; }

        public System.Data.Entity.DbSet<ToDoListExample.Models.List> Lists { get; set; }
    }
}
