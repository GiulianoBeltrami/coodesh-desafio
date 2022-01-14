using coodesh_desafio.Models;
using Microsoft.EntityFrameworkCore;

namespace coodesh_desafio.Context
{
    public class FlightNewsContext : DbContext
    {
        public FlightNewsContext(DbContextOptions<FlightNewsContext> options) : base(options)
        {

        }

        public DbSet<FlightNews> FlightNews { get; set; }
        public DbSet<LaunchesProvider> LaunchesProvider { get; set; }
        public DbSet<EventsProvider> EventsProvider { get; set; }
    }
}
