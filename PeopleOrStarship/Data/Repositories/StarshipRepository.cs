using System;
using System.Collections.Generic;
using System.Linq;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Data.Repositories
{
    public class StarshipRepository: BaseRepository<Starship>, IRepository<Starship>
    {
        public StarshipRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Starship GetById(int id)
        {
            return Context.Starships.SingleOrDefault(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var starhip = GetById(id);
            Context.Starships.Remove(starhip);
            SaveChanges();
        }

        public Starship CreateOrUpdate(Starship model)
        {
            if (model.Id > 0)
            {
                var dbStarship = GetById(model.Id);
                dbStarship.Consumables = model.Consumables;
                dbStarship.Crew = model.Crew;
                dbStarship.Length = model.Length;
                dbStarship.Manufacturer = model.Manufacturer;
                dbStarship.Name = model.Name;
                dbStarship.Model = model.Model;
                dbStarship.Passengers = model.Passengers;
                dbStarship.CargoCapacity = model.CargoCapacity;
                dbStarship.HyperdriveRating = model.HyperdriveRating;
                dbStarship.StarshipClass = model.StarshipClass;
                dbStarship.WinCount = model.WinCount;
                dbStarship.CostInCredits = model.CostInCredits;
                dbStarship.MaxAtmospheringSpeed = model.MaxAtmospheringSpeed;
            }
            else
            {
                Context.Starships.Add(model);
            }

            SaveChanges();

            return GetById(model.Id);
        }

        public IEnumerable<Starship> GetAll()
        {
            return Context.Starships.ToList();
        }
    }
}