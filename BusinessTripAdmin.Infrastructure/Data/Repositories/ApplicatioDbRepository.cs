using BusinessTripAdmin.Infrastructure.Data.Abstraction;

namespace BusinessTripAdmin.Infrastructure.Data.Repositories
{
    public class ApplicatioDbRepository : Repository, IApplicatioDbRepository
    {
        public ApplicatioDbRepository(ApplicationDbContext context)
        {
            Context = context;
        }
    }
}
