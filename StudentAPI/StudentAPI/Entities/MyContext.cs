using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentAPI.Entities
{
    public class MyContext:DbContext
    {
        public MyContext() { }
        public MyContext(DbContextOptions<MyContext>options) :base(options)
        {


        }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Course> Marks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = DBStudent; Integrated Security = True;");
        }


        }
}
