using CleanArchitectureWithCQRSandMediator.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediator.Infrastructure.Data
{
    public class BlogDbContext:DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Blog> Blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Description = "A very interesting book",
                    Name = "Name1",
                    Author= "Author1"
                },
                 new Blog
                 {
                     Id = 2,
                     Description = "A very interesting book",
                     Name = "Name2",
                     Author = "Author2"
                 },
                  new Blog
                  {
                      Id = 3,
                      Description = "A very interesting book",
                      Name = "Name3",
                      Author = "Author3"
                  },
                   new Blog
                   {
                       Id = 4,
                       Description = "A very interesting book",
                       Name = "Name4",
                       Author = "Author4"
                   },
                    new Blog
                    {
                        Id = 5,
                        Description = "A very interesting book",
                        Name = "Name5",
                        Author = "Author5"
                    }
            );
        }

    }
}
