using HelloWorldEFCoreAPI.Data;
using HelloWorldEFCoreAPI.Model.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HelloWorldEFCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public BlogPostsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        //[Authorize(Roles = "Writer")]
        [Route("AddBlogpost")]
        public async Task<IActionResult> CreateBlogPost([FromBody] BlogPost blogPost)
        {
            await dbContext.BlogPosts.AddAsync(blogPost);
            await dbContext.SaveChangesAsync();
            return Ok(blogPost);
        }
    }
}
