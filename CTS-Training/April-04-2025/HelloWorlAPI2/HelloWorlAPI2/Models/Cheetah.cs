namespace HelloWorlAPI2.Models
{
    public class Cheetah
    {
        public string Size { get; set; }
        public int Count { get; set; }
        public string Habitat { get; set; }
        public int Speed { get; set; }
        public string Diet { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public void UpdateDetails(string size, int count, string habitat, int speed, string diet, int age, string gender)
        {
            Size = size;
            Count = count;
            Habitat = habitat;
            Speed = speed;
            Diet = diet;
            Age = age;
            Gender = gender;
        }

        public string GetDetails()
        {
            return $"Size: {Size}\n" +
                   $"Count: {Count}\n" +
                   $"Habitat: {Habitat}\n" +
                   $"Speed: {Speed} km/h\n" +
                   $"Diet: {Diet}\n" +
                   $"Age: {Age} years\n" +
                   $"Gender: {Gender}\n";
        }
    }
}