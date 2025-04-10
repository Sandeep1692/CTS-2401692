using CineConnectAPI.Data;
using CineConnectAPI.Models.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CineConnectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheatreController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public TheatreController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        //[Authorize(Roles = "Writer")]
        [Route("AddTheatre")]
        public async Task<IActionResult> CreateTheatre([FromBody] Theatre addTheatre)
        {
            await dbContext.Theatres.AddAsync(addTheatre);
            await dbContext.SaveChangesAsync();
            return Ok(addTheatre);
        }
        [HttpGet]
        [Route("GetAllTheaters")]
        public async Task<IActionResult> GetAllTheaters()
        {
            var response = await dbContext.Theatres.ToListAsync();
            return Ok(response);
        }
        [HttpGet]
        [Route("GetTheaterById/{id}")]
        public async Task<IActionResult> GetTheaterById(int id)
        {
            var response = await dbContext.Theatres.FirstOrDefaultAsync(x => x.TheatreId == id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }
    }
}
