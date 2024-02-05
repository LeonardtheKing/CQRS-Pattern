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

namespace CleanArchitectureWithCQRSandMediator.Application.Blogs.Commands.CreateBlog
{

    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper? _mapper;
        public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
        }
        public async Task<BlogVm> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blogEntity = new Blog { Name = request.Name, Description = request.Description, Author = request.Author };
            var result = await _blogRepository.CreateBlogAsync(blogEntity);
           
            return new BlogVm { Name = result.Name,Id = result.Id, Description = result.Description,Author = result.Author };

        }
    }
}
