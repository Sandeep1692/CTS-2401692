namespace HelloWorlAPI2.Models
{
    public class Crocodile
    {
        public string Name { get; set; }
        public string ScientificName { get; set; }
        public int Age { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public string ConservationStatus { get; set; }

        public void UpdateDetails(string name, string scientificName, int age, double length, double weight, string habitat, string diet, string conservationStatus)
        {
            Name = string.IsNullOrEmpty(name) ? Name : name;
            ScientificName = string.IsNullOrEmpty(scientificName) ? ScientificName : scientificName;
            Age = age > 0 ? age : Age;
            Length = length > 0 ? length : Length;
            Weight = weight > 0 ? weight : Weight;
            Habitat = string.IsNullOrEmpty(habitat) ? Habitat : habitat;
            Diet = string.IsNullOrEmpty(diet) ? Diet : diet;
            ConservationStatus = string.IsNullOrEmpty(conservationStatus) ? ConservationStatus : conservationStatus;
        }

        public string GetDetails()
        {
            return $"Name: {Name}\n" +
                   $"Scientific Name: {ScientificName}\n" +
                   $"Age: {Age} years\n" +
                   $"Length: {Length} meters\n" +
                   $"Weight: {Weight} kg\n" +
                   $"Habitat: {Habitat}\n" +
                   $"Diet: {Diet}\n" +
                   $"Conservation Status: {ConservationStatus}\n";
        }
    }
}