using intro.Data;
using intro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace intro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Blog>> GeAllBlogs()
        {
            var blogs = _context.Blogs.Include(x => x.Header);

            return Ok(blogs);
        }

        [HttpPost]
        public ActionResult CreateBlog([FromBody] BlogDTO blog)
        {
            var newBlog = new Blog()
            {
                Id = blog.Id,
            };
            _context.Blogs.Add(newBlog);

            _context.SaveChanges();

            return NoContent();
        }
        
        [HttpPost("/header")]
        public ActionResult CreateBlogHeader([FromBody] BlogHeaderDTO header)
        {
            var newHeader = new BlogHeader()
            {
                BlogId = header.BlogId
            };
            _context.BlogsHeaders.Add(newHeader);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
