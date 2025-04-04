namespace HelloWorlAPI2.Models
{
    public class Lion
    {
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Habitat { get; set; }
        public string Diet { get; set; }
        public string PrideName { get; set; }
        public string ConservationStatus { get; set; }

        public void UpdateDetails(int age, string gender, double weight, double height, string habitat, string diet, string prideName, string conservationStatus)
        {
            Age = age;
            Gender = gender;
            Weight = weight;
            Height = height;
            Habitat = habitat;
            Diet = diet;
            PrideName = prideName;
            ConservationStatus = conservationStatus;
        }

        public string GetDetails()
        {
            return $"Age: {Age} years\n" +
                   $"Gender: {Gender}\n" +
                   $"Weight: {Weight} kg\n" +
                   $"Height: {Height} meters\n" +
                   $"Habitat: {Habitat}\n" +
                   $"Diet: {Diet}\n" +
                   $"Pride Name: {PrideName}\n" +
                   $"Conservation Status: {ConservationStatus}\n";
        }
    }
}