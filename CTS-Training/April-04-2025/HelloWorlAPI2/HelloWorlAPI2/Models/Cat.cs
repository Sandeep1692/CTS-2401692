namespace HelloWorlAPI2.Models
{
    public class Cat
    {
        public string Weight { get; set; }
        public string Height { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }

        public void UpdateDetails(string weight, string height, string breed, int age, string color, string name, string owner)
        {
            Weight = weight;
            Height = height;
            Breed = breed;
            Age = age;
            Color = color;
            Name = name;
            Owner = owner;
        }

        public string GetDetails()
        {
            return $"Name: {Name}\n" +
                   $"Breed: {Breed}\n" +
                   $"Weight: {Weight}\n" +
                   $"Height: {Height}\n" +
                   $"Age: {Age}\n" +
                   $"Color: {Color}\n" +
                   $"Owner: {Owner}\n";
        }
    }
}