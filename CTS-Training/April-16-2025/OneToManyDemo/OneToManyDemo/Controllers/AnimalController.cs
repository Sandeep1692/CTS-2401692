using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Data;
using OneToManyDemo.Models.Domain;
using OneToManyDemo.Models.DTO;

namespace OneToManyDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AnimalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all animals with their associated zoos
        [HttpGet]
        [Route("GetAnimals")]
        public async Task<ActionResult<IEnumerable<AnimalDto>>> GetAnimals()
        {
            var animals = await _context.Animals.Include(a => a.Zoo).ToListAsync();
            var animalDtos = animals.Select(a => new AnimalDto
            {
                Id = a.Id,
                Name = a.Name,
                Species = a.Species,
                Breed = a.Breed,
                Color = a.Color,
                Size = a.Size,
                Age = a.Age,
                ZooId = a.ZooId,
                ZooName = a.Zoo.Name
            }).ToList();

            return Ok(animalDtos);
        }

        // Get all zoos with their associated animals
        [HttpGet]
        [Route("GetZoos")]
        public async Task<ActionResult<IEnumerable<ZooDto>>> GetZoos()
        {
            var zoos = await _context.Zoos.Include(z => z.Animals).ToListAsync();
            var zooDtos = zoos.Select(z => new ZooDto
            {
                Id = z.Id,
                Name = z.Name,
                Location = z.Location,
                Animals = z.Animals.Select(a => new AnimalDto
                {
                    Id = a.Id,
                    Name = a.Name,
                    Species = a.Species,
                    Breed = a.Breed,
                    Color = a.Color,
                    Size = a.Size,
                    Age = a.Age,
                    ZooId = a.ZooId
                }).ToList()
            }).ToList();

            return Ok(zooDtos);
        }

        // Create a new animal
        [HttpPost]
        [Route("CreateAnimal")]
        public async Task<ActionResult<Animal>> CreateAnimal([FromBody] AnimalDto animalDto)
        {
            // Validate the input
            if (animalDto == null || string.IsNullOrEmpty(animalDto.Name) || animalDto.ZooId <= 0)
            {
                return BadRequest("Invalid Animal data.");
            }

            // Check if the Zoo exists
            var zoo = await _context.Zoos.FindAsync(animalDto.ZooId);
            if (zoo == null)
            {
                return NotFound($"Zoo with ID {animalDto.ZooId} not found.");
            }

            // Create a new Animal object from the DTO
            var animal = new Animal
            {
                Name = animalDto.Name,
                Species = animalDto.Species,
                Breed = animalDto.Breed,
                Color = animalDto.Color,
                Size = animalDto.Size,
                Age = animalDto.Age,
                ZooId = animalDto.ZooId
            };

            // Add the new Animal to the database
            _context.Animals.Add(animal);
            await _context.SaveChangesAsync();

            // Return the created Animal
            return CreatedAtAction(nameof(GetAnimals), new { id = animal.Id }, animal);
        }
    }
}