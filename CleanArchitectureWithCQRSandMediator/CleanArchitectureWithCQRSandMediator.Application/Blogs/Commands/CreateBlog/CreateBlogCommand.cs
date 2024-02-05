using CleanArchitectureWithCQRSandMediator.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureWithCQRSandMediator.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediator.Application.Blogs.Commands.CreateBlog
{
    public class CreateBlogCommand:IRequest<BlogVm>
    {
        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }= string.Empty;
        public string Author { get; set; } = string.Empty;
    }
}
