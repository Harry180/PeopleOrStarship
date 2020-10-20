using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PeopleOrStarship.Data;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Service
{
    public class RandomizeService : IRandomizeService
    {
        private readonly DataContext _context;

        public RandomizeService(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public People Get()
        {
            var first = _context.Peoples.FirstOrDefault();
            var last = _context.Peoples.LastOrDefault();
            
            
            var random = new Random();
            var id = -1;
            if (first != null && last != null)
            {
                id = random.Next(first.Id, last.Id);
            }

            var person = _context.Peoples.SingleOrDefault(x => x.Id == id);
            if (person == null)
            {
                throw new ArgumentNullException();
            }
            return person;
        }

        public Starship GetStarship()
        {
            var first = _context.Starships.FirstOrDefault();
            var last = _context.Starships.LastOrDefault();
            
            
            var random = new Random();
            var id = -1;
            if (first != null && last != null)
            {
                id = random.Next(first.Id, last.Id);
            }

            var starship = _context.Starships.SingleOrDefault(x => x.Id == id);
            if (starship == null)
            {
                throw new ArgumentNullException();
            }
            
            return starship;
        }
    }
}