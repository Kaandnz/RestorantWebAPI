
using WebApplication8.Models;

namespace WebApplication8.Repository
{
    public class IcecekRepository : GenericRepository<Icecek>, IIcecekRepository
    {
        public IcecekRepository(TaskDbContext dbContext) : base(dbContext) { }
    }
}
