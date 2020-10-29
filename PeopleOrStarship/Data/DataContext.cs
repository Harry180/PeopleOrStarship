using Microsoft.EntityFrameworkCore;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        
        public DbSet<Person> Peoples { get; set; }
        public DbSet<Starship> Starships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("People");
            base.OnModelCreating(modelBuilder);
        }
    }
}