using Microsoft.EntityFrameworkCore;

using WebApplication8.Models;

namespace WebApplication8.Repository
{
    public class GarsonRepository : GenericRepository<Garson> , IGarsonRepository
    {
        private readonly DbContext _taskDbContext;

        public GarsonRepository(TaskDbContext taskDbContext) : base(taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }

        public IEnumerable<Garson> GetComplatedGarsons()
        {

            return _dbSet.Where(x => x.siparisTamamlandi == true).ToList();
        }
        public IEnumerable<Garson> GetUnfinishedGarsons()
        {

            return _dbSet.Where(x => x.siparisTamamlandi == false).ToList();
        }
    }
}
