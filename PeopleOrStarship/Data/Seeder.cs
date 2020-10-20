using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Data
{
    public class Seeder
    {
        private readonly DataContext _context;
        private readonly IHostEnvironment _hosting;

        public Seeder(DataContext context, IHostEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }

        public void Seed()
        {
            _context.Database.EnsureCreated();

            if (!_context.Peoples.Any())
            {
                var filePath = Path.Combine(_hosting.ContentRootPath, "Data/people.json");
                var json = File.ReadAllText(filePath);
                var peoples = JsonConvert.DeserializeObject<IEnumerable<People>>(json);
                _context.Peoples.AddRange(peoples);
            }

            if (!_context.Starships.Any())
            {
                var filePath = Path.Combine(_hosting.ContentRootPath, "Data/starships.json");
                var json = File.ReadAllText(filePath);
                var starships = JsonConvert.DeserializeObject<IEnumerable<Starship>>(json);
                _context.Starships.AddRange(starships);
            }

            _context.SaveChanges();
        }
    }
}