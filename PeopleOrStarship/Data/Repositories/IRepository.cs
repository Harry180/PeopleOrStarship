using System.Collections.Generic;

namespace PeopleOrStarship.Data.Repositories
{
    public interface IRepository<T> where T: class
    {
        T GetById(int id);
        void Delete(int id);
        T CreateOrUpdate(T person);
        IEnumerable<T> GetAll();
    }
}