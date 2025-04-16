using System.Text.Json.Serialization;

namespace OneToManyDemo.Models.Domain
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Age { get; set; }
        public int ZooId { get; set; }

        [JsonIgnore]
        public Zoo Zoo { get; set; }
    }
}