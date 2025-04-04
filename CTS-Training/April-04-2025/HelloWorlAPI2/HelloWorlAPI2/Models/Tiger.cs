namespace HelloWorlAPI2.Models
{
    public class Tiger
    {
        public string Extinct { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public string Gender { get; set; }
        public string Subspecies { get; set; }

        public void UpdateDetails(string extinct, string status, int age, double weight, double length, string habitat, string diet, string gender, string subspecies)
        {
            Extinct = extinct;
            Status = status;
            Age = age;
            Weight = weight;
            Length = length;
            Habitat = habitat;
            Diet = diet;
            Gender = gender;
            Subspecies = subspecies;
        }

        public string GetDetails()
        {
            return $"Extinct: {Extinct}\n" +
                   $"Status: {Status}\n" +
                   $"Age: {Age} years\n" +
                   $"Weight: {Weight} kg\n" +
                   $"Length: {Length} meters\n" +
                   $"Habitat: {Habitat}\n" +
                   $"Diet: {Diet}\n" +
                   $"Gender: {Gender}\n" +
                   $"Subspecies: {Subspecies}\n";
        }
    }
}