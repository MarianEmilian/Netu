using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DataContext():base()
        {
            
        }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ToDoItem>()
                     .HasData(new ToDoItem[]{
                    ToDoItem.CreateProduct(1,"Server",DateTime.Now.AddDays(5).AddHours(12),false),
                    ToDoItem.CreateProduct(2,"API",DateTime.Now.AddDays(5).AddHours(16),true),
                    ToDoItem.CreateProduct(3,"Client",DateTime.Now.AddDays(5).AddHours(11),false),
                    ToDoItem.CreateProduct(4,"Front",DateTime.Now.AddDays(5).AddHours(5),true)
                     }); ;

        }
    }
}