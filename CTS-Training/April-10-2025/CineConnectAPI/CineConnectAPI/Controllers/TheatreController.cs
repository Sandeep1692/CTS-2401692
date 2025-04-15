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
                return NotFound($"Theatre with Id {id} is not found");
            }
            return Ok(response);
        }
        [HttpPut]
        [Route("UpdateTheatre/{id}")]
        public async Task<IActionResult> UpdateTheatre(int id, [FromBody] Theatre updateTheatre)
        {
            var existingTheatre = await dbContext.Theatres.FirstOrDefaultAsync(x => x.TheatreId == id);
            if (existingTheatre == null)
            {
                return NotFound($"Theatre with Id {id} is not found");
            }
            existingTheatre.Name = updateTheatre.Name;
            existingTheatre.Location = updateTheatre.Location;
            existingTheatre.Screens = updateTheatre.Screens;
            existingTheatre.ContactNumber = updateTheatre.ContactNumber;
            await dbContext.SaveChangesAsync();
            return Ok(existingTheatre);
        }
        [HttpDelete]
        [Route("DeleteTheatre/{id}")]
        public async Task<IActionResult> DeleteTheatre(int id)
        {
            var existingTheatre = await dbContext.Theatres.FirstOrDefaultAsync(x => x.TheatreId == id);
            if (existingTheatre == null)
            {
                return NotFound($"Theatre with Id {id} is not found");
            }
            dbContext.Theatres.Remove(existingTheatre);
            await dbContext.SaveChangesAsync();
            return Ok(existingTheatre);
        }
    }
}
