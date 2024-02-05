﻿using AutoMapper;
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
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVm>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogByIdQueryHandler(IBlogRepository blogRepository,IMapper mapper)
        {
            _blogRepository=blogRepository;
            _mapper=mapper;
        }
        public async Task<BlogVm> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
           var blog = await _blogRepository.GetBlogByIdAsync(request.BlogId);
           var returnblog = _mapper.Map<BlogVm>(blog);
            return returnblog;
            

        }
    }
}
