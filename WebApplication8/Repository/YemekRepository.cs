
using WebApplication8.Models;

namespace WebApplication8.Repository
{
    public class YemekRepository : GenericRepository<Yemek>, IYemekRepository
    {
        public YemekRepository(TaskDbContext dbContext) : base(dbContext) { }
    }
}
