using BusinessTripAdmin.Core.ViewModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IBusinessTripService
    {
        Task<ICollection<BusinessTripViewModel>> GelAllTrips(string userId);
    }
}
