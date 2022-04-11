using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.Constants;
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

        public async Task<bool> CreateCountry(CreateCountry createCountryViewModel)
        {
            var isCreated = true;
            var allowance = new Allowance
            {
                AccomodationAllowance = createCountryViewModel.AccomodationAllowance,
                DailyAllowance = createCountryViewModel.DailyAllowance,
                ValidFrom = createCountryViewModel.ValidFrom.Date,
                ValidTo = null
            };

            var country = new Country
            {
                CountryName = createCountryViewModel.CountryName,
                CurrencyCode = createCountryViewModel.CurrencyCode,
                Description = createCountryViewModel.Description,
                LocalCurrency = createCountryViewModel.LocalCurrency,
                TripCurrency = createCountryViewModel.TripCurrency,
                Allowances = new List<Allowance> { allowance }
            };

            try
            {
                await _applicationDbRepository.AddAsync<Country>(country);
                await _applicationDbRepository.SaveChangesAsync();
            }
            catch (OperationCanceledException)
            {
                isCreated = false;
            }

            return isCreated;
        }

        public async Task<IEnumerable<CountryViewModel>> GetAllCountries()
        {
            var countries = await _applicationDbRepository.GetAll<Country>().AsNoTracking().Include(x => x.Allowances).OrderByDescending(x => x.CreatedDate).Select(x => new CountryViewModel
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
