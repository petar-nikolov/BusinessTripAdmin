using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.DbModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryViewModel>> GetAllCountries();

        Task<Allowance> GetCurrentCountryAllowanceByCountryId(Guid countryId);

        Task<bool> CreateCountry(CreateCountry createCountryViewModel);
    }
}
