using AutoMapper;
using CleanArchitectureWithCQRSandMediator.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureWithCQRSandMediator.Domain.Entity;
using CleanArchitectureWithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediator.Application.Blogs.Queries.GetBlogById
{
    public class GetBlogByIdQuery: IRequest<BlogVm>
    {
        public int BlogId { get; set; }
    }
}
