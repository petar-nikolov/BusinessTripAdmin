//using BusinessTripAdmin.Core.Abstract;
//using BusinessTripAdmin.Core.ViewModels;
//using BusinessTripAdmin.Infrastructure.Data.Abstraction;
//using BusinessTripAdmin.Infrastructure.Data.DbModels;
//using Microsoft.EntityFrameworkCore;

//namespace BusinessTripAdmin.Core.Services
//{
//    public class CountryService : ICountryService
//    {
//        private readonly IApplicationDbRepository _applicationDbRepository;

//        public CountryService(IApplicationDbRepository applicationDbRepository)
//        {
//            _applicationDbRepository = applicationDbRepository;
//        }

//        public async Task<IEnumerable<CountryViewModel>> GetAllCountries()
//        {
//            var countries =  await _applicationDbRepository.GetAll<Country>().Select(x => new CountryViewModel
//            {
//                CountryName = x.CountryName,
//                CurrencyCode = x.CurrencyCode,
//                TripCurrency = x.TripCurrency,
//                Description = x.Description,
//                LocalCurrency = x.LocalCurrency,
               
//            }).ToListAsync();


//        }

//        public async Task<Allowance> GetCurrentCountryAllowance(Guid countryId)
//        {
//            var currentActiveAllowance = await _applicationDbRepository.GetAll<Allowance>().FirstOrDefaultAsync(x => x.cou);
//        }
//    }
//}
