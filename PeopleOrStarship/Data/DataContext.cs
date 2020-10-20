using Microsoft.EntityFrameworkCore;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        
        public DbSet<People> Peoples { get; set; }
        public DbSet<Starship> Starships { get; set; }
    }
}