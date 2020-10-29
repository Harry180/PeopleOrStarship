using System;
using System.Collections.Generic;
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
        public List<Person> Get()
        {
            var orderBy = _context.Peoples.OrderBy(x => x.Id);
            var first = orderBy.FirstOrDefault();
            var last = orderBy.LastOrDefault();


            var random = new Random();
            var ids = new List<int>();
            if (first == null || last == null)
            {
                throw new ArgumentException("People not exists in db.");
            }

            while (ids.Count() < 2)
            {
                var next = random.Next(first.Id, last.Id);
                if (!ids.Contains(next))
                {
                    ids.Add(next);
                }
            }

            var people = _context.Peoples.Where(x => ids.Contains(x.Id)).ToList();
            if (!people.Any())
            {
                throw new ArgumentNullException();
            }

            return people;
        }

        public List<Starship> GetStarship()
        {
            var orderBy = _context.Starships.OrderBy(x => x.Id);
            var first = orderBy.FirstOrDefault();
            var last = orderBy.LastOrDefault();


            var random = new Random();
            var ids = new List<int>();
            if (first == null || last == null)
            {
                throw new ArgumentException("Starships not exists in db.");
            }

            while (ids.Count() < 2)
            {
                var next = random.Next(first.Id, last.Id);
                if (!ids.Contains(next))
                {
                    ids.Add(next);
                }
            }

            var starships = _context.Starships.Where(x => ids.Contains(x.Id)).ToList();
            if (!starships.Any())
            {
                throw new ArgumentNullException();
            }

            return starships;
        }
    }
}