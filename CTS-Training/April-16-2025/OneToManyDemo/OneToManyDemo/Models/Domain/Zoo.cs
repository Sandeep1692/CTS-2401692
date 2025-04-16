using System.Text.Json.Serialization;

namespace OneToManyDemo.Models.Domain
{
    public class Zoo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        [JsonIgnore] // Prevent cyclical reference
        public ICollection<Animal> Animals { get; set; } = new List<Animal>();
    }
}