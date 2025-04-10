namespace CineConnectAPI.Models.Domain
{
    public class Movie
    {
        // Unique identifier for the movie
        public int MovieId { get; set; }

        // Name of the movie
        public string? Title { get; set; }

        // Duration of the movie in minutes
        public int Duration { get; set; }

        // Language of the movie
        public string? Language { get; set; }

        // Genre of the movie (e.g., Action, Drama)
        public string? Genre { get; set; }
    }
}