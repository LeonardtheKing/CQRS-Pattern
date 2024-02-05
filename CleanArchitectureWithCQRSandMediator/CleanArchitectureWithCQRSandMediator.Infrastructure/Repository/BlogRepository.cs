using CleanArchitectureWithCQRSandMediator.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureWithCQRSandMediator.Domain.Entity;
using CleanArchitectureWithCQRSandMediator.Domain.Repository;
using CleanArchitectureWithCQRSandMediator.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediator.Infrastructure.Repository
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogDbContext _blogDbContext;

        public BlogRepository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }
        public async Task<Blog> CreateBlogAsync(Blog blog)
        {
            await _blogDbContext.Blogs.AddAsync(blog);
           await _blogDbContext.SaveChangesAsync();
            return blog;
        }

        public async Task<int> DeleteBlogAsync(int id)
        {
            var blog = await _blogDbContext
                 .Blogs.Where(x => x.Id == id)
                 .ExecuteDeleteAsync();
            return blog;
        }

        public async Task<List<Blog>> GetAllBlogsAsync()
        {
            var blogs = await _blogDbContext.Blogs.ToListAsync();
            return blogs;
        }

        public async Task<Blog> GetBlogByIdAsync(int id)
        {
            var blog = await _blogDbContext
                .Blogs
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);
            return blog;
        }

        public async Task<int> UpdateBlogAsync(int id, Blog blog)
        {
            var updatedBlogs = await _blogDbContext
                .Blogs
                .Where(_x => _x.Id == id)
                .ExecuteUpdateAsync(setters => setters
                .SetProperty(s => s.Id, blog.Id)
                .SetProperty(s => s.Name, blog.Name)
                .SetProperty(s => s.Description, blog.Description)
                .SetProperty(s => s.Author, blog.Author)
                );
            return updatedBlogs;

        }
    }
}
