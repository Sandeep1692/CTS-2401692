using CineConnectAPI.Data;
using CineConnectAPI.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

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
                return NotFound($"Movie with id {id} is not found");
            }
            return Ok(response);
        }
        [HttpPut]
        [Route("UpdateMovie/{id}")]
        public async Task<IActionResult> UpdateMovie(int id, [FromBody] Movie updateMovie)
        {
            var existingMovie = await dbContext.Movies.FirstOrDefaultAsync(x => x.MovieId == id);
            if (existingMovie == null)
            {
                return NotFound($"Movie with Id {id} is not found");
            }
            existingMovie.Title = updateMovie.Title;
            existingMovie.Duration = updateMovie.Duration;
            existingMovie.Language = updateMovie.Language;
            existingMovie.Genre = updateMovie.Genre;
            await dbContext.SaveChangesAsync();
            return Ok(existingMovie);
        }
        [HttpDelete]
        [Route("DeleteMovie/{id}")]
        public async Task<IActionResult> ActionResult(int id)
        {
            var existingMovie = await dbContext.Movies.FirstOrDefaultAsync(x => x.MovieId == id);
            if (existingMovie == null)
            {
                return NotFound($"Movie with Id {id} is not found");
            }
            dbContext.Movies.Remove(existingMovie);
            await dbContext.SaveChangesAsync();
            return Ok(existingMovie);
        }
    }
}
