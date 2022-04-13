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

        public async Task<bool> CreateAllowanceByCountryName(string countryName, CreateAllowance allowanceViewModel)
        {
            var isCreated = true;
            var country = await GetCountryByName(countryName);
            var allowance = new Allowance();
            if (country == null)
            {
                isCreated = false;
            }
            else
            {
                allowance.DailyAllowance = allowanceViewModel.DailyAllowance;
                allowance.AccomodationAllowance = allowanceViewModel.AccomodationAllowance;
                allowance.ValidFrom = allowanceViewModel.ValidFrom;
                allowance.ValidTo = allowanceViewModel.ValidTo;
                allowance.CountryId = country.Id;
            }
            try
            {
                await _applicationDbRepository.AddAsync<Allowance>(allowance);
                await _applicationDbRepository.SaveChangesAsync();
            }
            catch (OperationCanceledException)
            {
                isCreated = false;
            }

            return isCreated;

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
            catch (Exception ex)
            when (ex is DbUpdateException ||
                  ex is DbUpdateConcurrencyException ||
                  ex is OperationCanceledException)
            {
                isCreated = false;
            }

            return isCreated;
        }

        public async Task<bool> EditCountry(Guid countryId, EditCountry editCountryViewModel)
        {
            var countryToEdit = await GetCountryById(countryId);
            var isEditted = true;

            countryToEdit.CountryName = editCountryViewModel.CountryName;
            countryToEdit.TripCurrency = editCountryViewModel.TripCurrency;
            countryToEdit.LocalCurrency = editCountryViewModel.LocalCurrency;
            countryToEdit.CurrencyCode = editCountryViewModel.CurrencyCode;
            countryToEdit.Description = editCountryViewModel.Description;
            countryToEdit.UpdatedDate = DateTime.Now;

            try
            {
                await _applicationDbRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            when (ex is DbUpdateException ||
                  ex is DbUpdateConcurrencyException ||
                  ex is OperationCanceledException)
            {
                isEditted = false;
            }

            return isEditted;
        }

        public async Task<IEnumerable<CountryViewModel>> GetAllCountries()
        {
            var countries = await _applicationDbRepository.GetAll<Country>().AsNoTracking().Include(x => x.Allowances).OrderByDescending(x => x.CreatedDate).Select(x => new CountryViewModel
            {
                CountryId = x.Id,
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

        public async Task<IEnumerable<AllowanceViewModel>> GetAllCountryAllowancesByCountryName(string countryName)
        {
            var country = await GetCountryByName(countryName);
            var countryAllowances = new List<AllowanceViewModel>();
            if (country != null)
            {
                countryAllowances = country.Allowances.Select(x => new AllowanceViewModel
                {
                    CountryName = countryName,
                    AccomodationAllowance = x.AccomodationAllowance,
                    DailyAllowance = x.DailyAllowance,
                    ValidFrom = x.ValidFrom,
                    ValidTo = x.ValidTo
                }).ToList();
            }

            return countryAllowances;
        }

        public async Task<Country> GetCountryById(Guid countryId)
        {
            var country = await _applicationDbRepository.GetAll<Country>().Include(x => x.Allowances).FirstOrDefaultAsync(x => x.Id == countryId);
            return country;
        }

        public async Task<Country> GetCountryByName(string countryName)
        {
            var country = await _applicationDbRepository.GetAll<Country>().Include(x => x.Allowances).FirstOrDefaultAsync(x => x.CountryName == countryName);
            return country;
        }
    }
}
