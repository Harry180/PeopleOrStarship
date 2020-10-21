using System.Collections.Generic;
using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Service
{
    public interface IRandomizeService
    {
        List<People> Get();
        List<Starship> GetStarship();
    }
}