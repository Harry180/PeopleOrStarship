using PeopleOrStarship.Data.Entities;

namespace PeopleOrStarship.Service
{
    public interface IRandomizeService
    {
        People Get();
        Starship GetStarship();
    }
}