using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Core.Services
{
    public class CountryService : ICountryService
    {
        private readonly IApplicationDbRepository _applicationDbRepository;

        public CountryService(IApplicationDbRepository applicationDbRepository)
        {
            _applicationDbRepository = applicationDbRepository;
        }

        public async Task<IEnumerable<CountryViewModel>> GetAllCountries()
        {
            var countries = await _applicationDbRepository.GetAll<Country>().Include(x => x.Allowances).Select(x => new CountryViewModel
            {
                CountryName = x.CountryName,
                CurrencyCode = x.CurrencyCode,
                TripCurrency = x.TripCurrency,
                Description = x.Description,
                LocalCurrency = x.LocalCurrency,
                AccomodationAllowance = x.GetCurrentCountryAllowance().AccomodationAllowance,
                DailyAllowance = x.GetCurrentCountryAllowance().DailyAllowance

            }).ToListAsync();

            return countries;
        }

        public async Task<Allowance> GetCurrentCountryAllowanceByCountryId(Guid countryId)
        {
            var currentActiveAllowance = await _applicationDbRepository.GetAll<Allowance>().FirstOrDefaultAsync(x => x.CountryId == countryId &&
                                                                                                                     x.ValidFrom <= DateTime.Today &&
                                                                                                                     x.ValidTo > DateTime.Today);
            return currentActiveAllowance;
        }
    }
}
