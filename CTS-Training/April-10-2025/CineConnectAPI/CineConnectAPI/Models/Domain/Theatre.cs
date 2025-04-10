namespace CineConnectAPI.Models.Domain
{
    public class Theatre
    {
        // Unique identifier for the theater
        public int TheatreId { get; set; }

        // Name of the theater
        public string? Name { get; set; }

        // Address or city of the theater
        public string? Location { get; set; }

        // List of screens in the theater
        public List<int>? Screens { get; set; }

        // Contact number for the theater management
        public string? ContactNumber { get; set; }
    }
}