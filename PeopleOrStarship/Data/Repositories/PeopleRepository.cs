using System;
using System.Collections.Generic;
using System.Linq;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Data.Repositories
{
    public class PeopleRepository : BaseRepository<Person>, IRepository<Person>
    {
        public PeopleRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public IEnumerable<Person> GetAll()
        {
            return Context.Peoples.ToList();
        }

        public Person CreateOrUpdate(Person person)
        {
            if (person.Id > 0)
            {
                var dbPerson = GetById(person.Id);
                dbPerson.Gender = person.Gender;
                dbPerson.Height = person.Height;
                dbPerson.Mass = person.Mass;
                dbPerson.Name = person.Name;
                dbPerson.BirthYear = person.BirthYear;
                dbPerson.EyeColor = person.EyeColor;
                dbPerson.HairColor = person.HairColor;
                dbPerson.SkinColor = person.SkinColor;
                dbPerson.WinCount = person.WinCount;
            }
            else
            {
                Context.Peoples.Add(person);
            }

            SaveChanges();
            return GetById(person.Id);
        }

        public void Delete(int id)
        {
            var person = GetById(id);

            if (person == null)
            {
                throw new ArgumentOutOfRangeException();
            }

            Context.Peoples.Remove(person);
            SaveChanges();
        }

        public Person GetById(int id)
        {
            return Context.Peoples.SingleOrDefault(x => x.Id == id);
        }
    }
}