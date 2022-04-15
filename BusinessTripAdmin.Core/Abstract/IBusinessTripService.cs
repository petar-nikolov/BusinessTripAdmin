using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.DbModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IBusinessTripService
    {
        Task<ICollection<BusinessTripViewModel>> GelAllTrips(string userId);

        Task<(IEnumerable<CountryViewModel>, IEnumerable<EmployeeViewModel>)> GetDataForCreateAsync(string userId);
    }
}
