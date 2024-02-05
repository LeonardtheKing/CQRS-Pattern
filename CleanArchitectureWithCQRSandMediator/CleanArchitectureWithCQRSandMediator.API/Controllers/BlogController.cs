using CleanArchitectureWithCQRSandMediator.Application.Blogs.Commands.CreateBlog;
using CleanArchitectureWithCQRSandMediator.Application.Blogs.Commands.DeleteBlog;
using CleanArchitectureWithCQRSandMediator.Application.Blogs.Commands.UpdateBlog;
using CleanArchitectureWithCQRSandMediator.Application.Blogs.Queries.GetBlogById;
using CleanArchitectureWithCQRSandMediator.Application.Blogs.Queries.GetBlogs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureWithCQRSandMediator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController :APIControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var blogs = await Mediator.Send(new GetBlogQuery());
            return Ok(blogs);
        }

        [HttpGet("{id}", Name = nameof(GetByIdAsync))]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var blog = await Mediator.Send(new GetBlogByIdQuery() { BlogId=id});
            if(blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
          var createdBlog = await Mediator.Send(command);
            if(createdBlog == null)
            {
                return BadRequest();
            }
            return CreatedAtRoute(nameof(GetByIdAsync), new { id = createdBlog.Id }, createdBlog);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,UpdateBlogCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }
           await Mediator.Send(command);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
           await  Mediator.Send(new DeleteBlogCommand { Id = id });
            return NoContent();
        }
    }
}
