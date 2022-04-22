using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.DbModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryViewModel>> GetAllCountries();

        Task<bool> CreateCountry(CreateCountry createCountryViewModel);

        Task<bool> EditCountry(Guid countryId, EditCountry editCountryViewModel);

        Task<IEnumerable<AllowanceViewModel>> GetAllCountryAllowancesByCountryName(string countryName);

        Task<bool> CreateAllowanceByCountryName(string countryName, CreateAllowance allowanceViewModel);

        Task<Country> GetCountryByName(string countryName);

        Task<Country> GetCountryById(Guid countryId);

        Task<bool> EditAllowance(Guid allowanceId, CreateAllowance editAllowanceModel);

        Task<Allowance> GetAllowanceById(Guid allowanceId);

        Task<bool> ValidateAllowanceValidDates(string countryName, DateTime validFromDate, DateTime? ValidToDate);
    }
}
