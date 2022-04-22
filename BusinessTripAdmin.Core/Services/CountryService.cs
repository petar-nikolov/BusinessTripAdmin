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

        public async Task<bool> CreateAllowanceByCountryName(string countryName, CreateAllowance createAllowance)
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
                allowance.DailyAllowance = createAllowance.DailyAllowance;
                allowance.AccomodationAllowance = createAllowance.AccomodationAllowance;
                allowance.ValidFrom = createAllowance.ValidFrom;
                allowance.ValidTo = createAllowance.ValidTo;
                allowance.CountryId = country.Id;
            }

            var isAllowancesValid = await ValidateAllowanceValidDates(countryName, createAllowance.ValidFrom, createAllowance.ValidTo);
            if (!isAllowancesValid)
            {
                return false;
            }

            try
            {
                await _applicationDbRepository.AddAsync<Allowance>(allowance);
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

        public async Task<bool> EditAllowance(Guid allowanceId, CreateAllowance editAllowanceModel)
        {
            Allowance allowanceToEdit;
            try
            {
                allowanceToEdit = await GetAllowanceById(allowanceId);

            }
            catch (ArgumentException)
            {
                return false;
            }

            var isAllowancesValid = await ValidateAllowanceValidDates(allowanceToEdit.Country.CountryName, editAllowanceModel.ValidFrom, editAllowanceModel.ValidTo);
            if (!isAllowancesValid)
            {
                return false;
            }

            var isEditted = true;

            allowanceToEdit.DailyAllowance = editAllowanceModel.DailyAllowance;
            allowanceToEdit.AccomodationAllowance = editAllowanceModel.AccomodationAllowance;
            allowanceToEdit.ValidFrom = editAllowanceModel.ValidFrom;
            allowanceToEdit.ValidTo = editAllowanceModel.ValidTo;

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

        public async Task<bool> EditCountry(Guid countryId, EditCountry editCountryViewModel)
        {
            Country countryToEdit;
            try
            {
                countryToEdit = await GetCountryById(countryId);

            }
            catch (ArgumentException)
            {
                return false;
            }
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
            var countryAllowances = new List<AllowanceViewModel>();
            var country = await GetCountryByName(countryName);
            if (country != null)
            {
                countryAllowances = country.Allowances.Select(x => new AllowanceViewModel
                {
                    CountryName = countryName,
                    AccomodationAllowance = x.AccomodationAllowance,
                    DailyAllowance = x.DailyAllowance,
                    ValidFrom = x.ValidFrom,
                    ValidTo = x.ValidTo,
                    AllowanceId = x.Id
                }).ToList();
            }

            return countryAllowances;
        }

        public async Task<Country> GetCountryById(Guid countryId)
        {
            var country = await _applicationDbRepository.GetAll<Country>().Include(x => x.Allowances).FirstOrDefaultAsync(x => x.Id == countryId);
            if (country == null)
            {
                throw new ArgumentException("No Country");
            }

            return country;
        }

        public async Task<Country> GetCountryByName(string countryName)
        {
            var country = await _applicationDbRepository.GetAll<Country>().Include(x => x.Allowances).FirstOrDefaultAsync(x => x.CountryName == countryName);
            return country;
        }

        public async Task<Allowance> GetAllowanceById(Guid allowanceId)
        {
            var allowance = await _applicationDbRepository.GetAll<Allowance>().Include(x => x.Country).FirstOrDefaultAsync(x => x.Id == allowanceId);

            if (allowance == null)
            {
                throw new ArgumentException("No Allowance");
            }

            return allowance;
        }

        private async Task MaintainPastAllowanceValidToDate(Allowance allowance)
        {
            var countryAllowances = await GetAllAllowancesPerCountry(allowance.CountryId);

            var validFromDate = allowance.ValidFrom;

            var allowanceToMaintain = countryAllowances.FirstOrDefault(x => (x.ValidFrom < validFromDate && x.ValidTo == null) ||
                                                                            (x.ValidFrom < validFromDate && x.ValidTo >= validFromDate));
            if (allowanceToMaintain != null)
            {
                allowanceToMaintain.ValidTo = validFromDate.AddDays(-1);
                try
                {
                    await _applicationDbRepository.SaveChangesAsync();
                }
                catch (Exception ex)
                when (ex is DbUpdateException ||
                      ex is DbUpdateConcurrencyException ||
                      ex is OperationCanceledException)
                {
                    throw;
                }
            }
        }

        private async Task<IEnumerable<Allowance>> GetAllAllowancesPerCountry(Guid countryId)
        {
            var countryAllowances = await _applicationDbRepository.GetAll<Allowance>().Where(x => x.CountryId == countryId).ToListAsync();
            return countryAllowances;
        }

        public async Task<bool> ValidateAllowanceValidDates(string countryName, DateTime validFromDate, DateTime? ValidToDate)
        {
            var countryAllowances = await GetAllCountryAllowancesByCountryName(countryName);

            var matchingAllowance = countryAllowances.Any(x => (x.ValidFrom <= ValidToDate && x.ValidTo >= ValidToDate) ||
                                                                (x.ValidFrom <= ValidToDate && x.ValidTo == null) ||
                                                                (x.ValidFrom <= validFromDate && x.ValidTo >= validFromDate) ||
                                                                (x.ValidFrom <= validFromDate && x.ValidTo == null));

            return !matchingAllowance;

        }
    }
}
