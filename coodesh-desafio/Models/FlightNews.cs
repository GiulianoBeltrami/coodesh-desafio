using System.Collections.Generic;

namespace coodesh_desafio.Models
{
    public class FlightNews
    {
        public int Id { get; set; }
        public bool Featured { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string NewsSite { get; set; }
        public string Summary { get; set; }
        public string PublishedAt { get; set; }
        public ICollection<LaunchesProvider> Launches { get; set; }
        public ICollection<EventsProvider> Events { get; set; }

    }
}
