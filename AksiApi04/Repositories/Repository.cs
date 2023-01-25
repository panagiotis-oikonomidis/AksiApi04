using AksiApi.Context;
using AksiApi.Repositories.Interfaces;

namespace AksiApi.Repositories
{

    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AtaContext _context;

        public Repository(AtaContext context)
        {
            _context = context;
        }
    }
}
