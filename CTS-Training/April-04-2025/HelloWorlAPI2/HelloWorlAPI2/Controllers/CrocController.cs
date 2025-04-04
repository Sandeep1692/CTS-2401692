using HelloWorlAPI2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HelloWorlAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class crocController : ControllerBase
    {
        [HttpGet]
        [Route("Crocodile")]
        public async Task<IActionResult> GetRandomCroc()
        {
            Crocodile croco = new Crocodile();
            var name = "Nile Crocodile";
            var scientificName = "Crocodylus niloticus";
            var age = 12;
            var length = 4.5;
            var weight = 500;
            var habitat = "Freshwater rivers and lakes";
            var diet = "Fish, birds, mammals";
            var conservationStatus = "Least Concern";
            croco.UpdateDetails(name, scientificName, age, length, weight, habitat, diet, conservationStatus);
            return Ok(croco);
        }

        [HttpGet]
        [Route("Lion")]
        public async Task<IActionResult> GetRandomLion()
        {
            Lion lion = new Lion();
            var age = 5;
            var gender = "Male";
            var weight = 190.5;
            var height = 1.2;
            var habitat = "Savannah, grasslands";
            var diet = "Large herbivores";
            var prideName = "Pride of the Serengeti";
            var conservationStatus = "Vulnerable";
            lion.UpdateDetails(age, gender, weight, height, habitat, diet, prideName, conservationStatus);
            return Ok(lion);
        }


        [HttpGet]
        [Route("Cat")]
        public async Task<IActionResult> GetRandomCat()
        {
            Cat cat = new Cat();
            var weight = "5kg";
            var height = "0.3m";
            var breed = "Siamese";
            var age = 3;
            var color = "Cream";
            var name = "Whiskers";
            var owner = "John Doe";
            cat.UpdateDetails(weight, height, breed, age, color, name, owner);
            return Ok(cat);
        }

        [HttpGet]
        [Route("Tiger")]
        public async Task<IActionResult> GetRandomTiger()
        {
            Tiger tiger = new Tiger();
            var extinct = "No";
            var status = "Endangered";
            var age = 8;
            var weight = 220.5;
            var length = 2.8;
            var habitat = "Forests, grasslands";
            var diet = "Deer, wild boar";
            var gender = "Female";
            var subspecies = "Bengal Tiger";
            tiger.UpdateDetails(extinct, status, age, weight, length, habitat, diet, gender, subspecies);
            return Ok(tiger);
        }

        [HttpGet]
        [Route("Cheetah")]
        public async Task<IActionResult> GetRandomCheetah()
        {
            Cheetah cheetah = new Cheetah();
            var size = "Medium";
            var count = 7000;
            var habitat = "Savannah, grasslands";
            var speed = 110;
            var diet = "Gazelles, hares";
            var age = 6;
            var gender = "Male";
            cheetah.UpdateDetails(size, count, habitat, speed, diet, age, gender);
            return Ok(cheetah);
        }
        [HttpPost]
        [Route("CreateCroc")]
        public async Task<IActionResult> CreateCroc([FromBody] Crocodile crocodile)
        {
            var temp = crocodile;
            return Ok("Croc Received");
        }
        [HttpPost]
        [Route("CreateCroc2")]
        public async Task<IActionResult> CreateCroc2([FromBody] Crocodile crocodile)
        {
            var tempcroc = crocodile;
            return Ok(tempcroc);
        }
    }
}