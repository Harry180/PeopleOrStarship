using System.Collections.Generic;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Service
{
    public interface IRandomizeService
    {
        List<Person> Get();
        List<Starship> GetStarship();
    }
}