using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.DbModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryViewModel>> GetAllCountries();

        Task<bool> CreateCountry(CreateCountry createCountryViewModel);

        Task<bool> EditCountry(string countryName, EditCountry editCountryViewModel);

        Task<IEnumerable<AllowanceViewModel>> GetAllCountryAllowancesByCountryName(string countryName);

        Task<bool> CreateAllowanceByCountryName(string countryName, CreateAllowance allowanceViewModel);

        Task<Country> GetCountryByName(string countryName);

    }
}
