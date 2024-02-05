using AutoMapper;
using CleanArchitectureWithCQRSandMediator.Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureWithCQRSandMediator.Application.Blogs.Queries.GetBlogs
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVm>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public GetBlogQueryHandler(IBlogRepository blogRepository,IMapper mapper)
        {
            _blogRepository=blogRepository;
            _mapper=mapper;
        }
        public async Task<List<BlogVm>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
           var blogs = await _blogRepository.GetAllBlogsAsync();
            //souce=>blogs 
            //destination=>BlogVm
            var blogList=_mapper.Map<List<BlogVm>>(blogs);
            //var blogList=blogs.Select(x => new BlogVm {Id=x.Id,Author=x.Author,Description=x.Description }).ToList();
            return blogList;
        }
    }
}
