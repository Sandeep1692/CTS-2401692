using CineConnectAPI.Data;
using CineConnectAPI.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineConnectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public MovieController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        //[Authorize(Roles = "Writer")]
        [Route("AddMovies")]
        public async Task<IActionResult> CreateMovies([FromBody] Movie addMovies)
        {
            await dbContext.Movies.AddAsync(addMovies);
            await dbContext.SaveChangesAsync();
            return Ok(addMovies);
        }
        [HttpGet]
        [Route("GetAllMovies")]
        public async Task<IActionResult> GetAllMovies()
        {
            var response = await dbContext.Movies.ToListAsync();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetMovieById/{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var response = await dbContext.Movies.FirstOrDefaultAsync(x => x.MovieId == id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
