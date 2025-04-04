using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldAPI.Controllers
{
    [Route("sandeep/[controller]")]
    [ApiController]
    public class CrocController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public async Task<IActionResult> Getcroc()
        {
            var temp = "Hello From CrocController";
            return Ok(temp);
        }
        [HttpGet]
        [Route("RandCroc")]
        public async Task<IActionResult> CrocRandom()
        {
            CrocodileCollectionProcessor crocProcessor = new CrocodileCollectionProcessor();
            Crocodile croc = Crocodile.CrocRandom();
            string details = croc.GetDetails();
            return Ok(details);
        }
    }

    class Crocodile
    {
        public int weight { get; set; }
        public string speciesname { get; set; }
        public string scientificname { get; set; }
        public double length { get; set; }
        public bool isExtinct { get; set; }
        public string ExtinctStatus { get; set; }
        public int Lifespan { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Species Name: {speciesname}");
            Console.WriteLine($"Scientific Name: {scientificname}");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Length: {length} feet");
            Console.WriteLine($"Is Extinct: {isExtinct}");
            Console.WriteLine($"Extinct Status: {ExtinctStatus}");
            Console.WriteLine($"Lifespan: {Lifespan} years");
        }

        public string GetDetails()
        {
            return $"Species Name: {speciesname}\n" +
                   $"Scientific Name: {scientificname}\n" +
                   $"Weight: {weight} kg\n" +
                   $"Length: {length} feet\n" +
                   $"Is Extinct: {isExtinct}\n" +
                   $"Extinct Status: {ExtinctStatus}\n" +
                   $"Lifespan: {Lifespan} years\n";
        }

        public static Crocodile CollectCrocodileDetails()
        {
            Crocodile croc = new Crocodile();
            Console.WriteLine("Enter details for the crocodile:");
            Console.Write("Weight (kg): ");
            croc.weight = int.Parse(Console.ReadLine());
            Console.Write("Species Name: ");
            croc.speciesname = Console.ReadLine();
            Console.Write("Scientific Name: ");
            croc.scientificname = Console.ReadLine();
            Console.Write("Length (feet): ");
            croc.length = double.Parse(Console.ReadLine());
            Console.Write("Is Extinct (true/false): ");
            croc.isExtinct = bool.Parse(Console.ReadLine());
            Console.Write("Extinct Status: ");
            croc.ExtinctStatus = Console.ReadLine();
            Console.Write("Lifespan (years): ");
            croc.Lifespan = int.Parse(Console.ReadLine());
            return croc;
        }

        public static bool CheckCrocodileDetails(Crocodile croc)
        {
            if (croc.weight <= 0 || string.IsNullOrEmpty(croc.speciesname) || string.IsNullOrEmpty(croc.scientificname) ||
                croc.length <= 0 || string.IsNullOrEmpty(croc.ExtinctStatus) || croc.Lifespan <= 0)
            {
                return false;
            }
            return true;
        }
        public static Crocodile CrocRandom()
        {
            Crocodile croc = new Crocodile();
            Console.WriteLine("Enter details for the crocodile:");
            Console.Write("Weight (kg): ");
            croc.weight = 70;
            Console.Write("Species Name: ");
            croc.speciesname = "Saltwater Crocodile";
            Console.Write("Scientific Name: ");
            croc.scientificname = "Crocodylus porosus";
            Console.Write("Length (feet): ");
            croc.length = 15.0;
            Console.Write("Is Extinct (true/false): ");
            croc.isExtinct = false;
            Console.Write("Extinct Status: ");
            croc.ExtinctStatus = "Endagangered";
            Console.Write("Lifespan (years): ");
            croc.Lifespan = 40;
            return croc;
        }

    }

    class CrocodileCollectionProcessor
    {
        public List<Crocodile> CollectNCrocodiles(int n)
        {
            List<Crocodile> crocodiles = new List<Crocodile>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nCollecting details for crocodile {i + 1}:");
                Crocodile croc = Crocodile.CollectCrocodileDetails();
                while (!Crocodile.CheckCrocodileDetails(croc))
                {
                    Console.WriteLine("Invalid details entered. Please re-enter the details for the crocodile.");
                    croc = Crocodile.CollectCrocodileDetails();
                }
                crocodiles.Add(croc);
            }
            return crocodiles;
        }

        public string DisplayNCrocodiles(List<Crocodile> crocodiles)
        {
            if (crocodiles == null || crocodiles.Count == 0)
            {
                return "No crocodiles to display.";
            }

            string details = "";
            for (int i = 0; i < crocodiles.Count; i++)
            {
                details += $"\nDetails of crocodile {i + 1}:\n";
                details += crocodiles[i].GetDetails();
            }
            return details;
        }
    }
}
