namespace OneToManyDemo.Models.DTO
{
    public class ZooDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<AnimalDto> Animals { get; set; }
    }
}