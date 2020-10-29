using System;
using System.Collections.Generic;

namespace PeopleOrStarship.Data.Repositories
{
    // TODO: Implement all needed operations to context here _dataContext.Set(typeof(T)) - to get non generic dbsets by type
    public class BaseRepository<T>
    {
        private readonly DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public DataContext Context => _dataContext;

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }
    }
}