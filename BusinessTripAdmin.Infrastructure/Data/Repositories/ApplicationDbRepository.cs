using BusinessTripAdmin.Infrastructure.Data.Abstraction;

namespace BusinessTripAdmin.Infrastructure.Data.Repositories
{
    public class ApplicationDbRepository : Repository, IApplicationDbRepository
    {
        public ApplicationDbRepository(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}
