using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Core.Services
{
    public class BusinessTripService : IBusinessTripService
    {
        private readonly IUserService _userService;
        private readonly IEmployeeService _employeeService;
        private readonly ICountryService _countryService;
        private readonly IApplicationDbRepository _applicationDbRepository;

        public BusinessTripService(IUserService userService, IEmployeeService employeeService, IApplicationDbRepository applicationDbRepository, ICountryService countryService)
        {
            _userService = userService;
            _employeeService = employeeService;
            _applicationDbRepository = applicationDbRepository;
            _countryService = countryService;
        }

        public async Task<bool> CreateBusinessTrip(CreateBusinessTrip createBusinessTrip)
        {
            var isCreated = true;

            var businessTripDetail = new TripDetail
            {
                TripBy = createBusinessTrip.TripBy,
                TransportNumber = createBusinessTrip.TransportNumber
            };

            var businessTrips = new List<EmployeeBusinessTrip>();
            foreach (var employeeId in createBusinessTrip.Employees)
            {
                var businessTrip = new EmployeeBusinessTrip
                {
                    DateFrom = createBusinessTrip.DateFrom,
                    DateTo = createBusinessTrip.DateTo,
                    TripFrom = createBusinessTrip.TripFrom,
                    TripTo = createBusinessTrip.TripTo,
                    EmployeeId = Guid.Parse(employeeId),
                    TripDetail = businessTripDetail,
                    Purpose = createBusinessTrip.Purpose,
                    TotalDays = (int)(createBusinessTrip.DateTo - createBusinessTrip.DateFrom).TotalDays + 1
                };

                businessTrips.Add(businessTrip);
            }

            try
            {
                await _applicationDbRepository.AddRangeAsync(businessTrips);
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

        public async Task<ICollection<BusinessTripViewModel>> GelAllTrips(string userId)
        {
            var userOrgId = await _userService.GetOrganizationIdByUserId(userId);
            var organizationEmployees = await _employeeService.GetActiveEmployeesByOrganizationId(userOrgId);
            var employeeIds = organizationEmployees.Where(x => x.IsActive).Select(x => x.EmployeeId).ToList();
            var businessTrips = await _applicationDbRepository.GetAll<EmployeeBusinessTrip>()
                .Include(x => x.Employee)
                .Where(x => employeeIds.Any(eid => eid == x.EmployeeId)).Include(x => x.TripDetail)
                .OrderByDescending(x => x.CreatedDate)
                .Select(bt => new BusinessTripViewModel
                {
                    Employee = $"{bt.Employee.FirstName} {bt.Employee.LastName}",
                    EmployeeId = bt.EmployeeId,
                    DateFrom = bt.DateFrom.Date,
                    DateTo = bt.DateTo.Date,
                    TotalDays = bt.TotalDays,
                    TripFrom = bt.TripFrom,
                    TripTo = bt.TripTo,
                    TripBy = bt.TripDetail.TripBy,
                    Purpose = bt.Purpose,
                    BusinessTripId = bt.Id
                }).ToListAsync();

            foreach (var trip in businessTrips)
            {
                trip.TotalDailyAllowance = await CalculateTotalDailyAllowance(trip.TripTo, trip.TotalDays);
                trip.TotalAccomodationAllowance = await CalculateTotalAccomodationAllowance(trip.TripTo, trip.TotalDays); 
                trip.TripCurrency = await DefineAllowanceCurrency(trip.TripTo);
            }

            return businessTrips;
        }

        public async Task<(IEnumerable<CountryViewModel>, IEnumerable<EmployeeViewModel>)> GetDataForCreateAsync(string userId)
        {
            var userOrgId = await _userService.GetOrganizationIdByUserId(userId);
            var organizationEmployees = await _employeeService.GetActiveEmployeesByOrganizationId(userOrgId);
            var countries = await _countryService.GetAllCountries();
            return (countries, organizationEmployees);
        }

        private async Task<decimal> CalculateTotalDailyAllowance(string countryName, int totalDays)
        {
            var country = await _countryService.GetCountryByName(countryName);
            var currentCountryAllowance = country.GetCurrentCountryAllowance();
            var totalDailyAllowance = totalDays * currentCountryAllowance.DailyAllowance;
            return totalDailyAllowance;
        }

        private async Task<decimal> CalculateTotalAccomodationAllowance(string countryName, int totalDays)
        {
            var country = await _countryService.GetCountryByName(countryName);
            var currentCountryAllowance = country.GetCurrentCountryAllowance();
            var totalDailyAllowance = totalDays > 1 ? totalDays * currentCountryAllowance.AccomodationAllowance : 0;
            return totalDailyAllowance;
        }

        private async Task<string> DefineAllowanceCurrency(string countryName)
        {
            var country = await _countryService.GetCountryByName(countryName);
            return country.CurrencyCode.ToString();
        }

        public async Task<EmployeeBusinessTrip> GetTripById(Guid id)
        {
            var businessTrip = await _applicationDbRepository.GetAll<EmployeeBusinessTrip>()
                .Include(e => e.Employee)
                .Include(e => e.TripDetail)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (businessTrip == null)
            {
                throw new ArgumentException("No trip to return");
            }

            return businessTrip;
        }

        public async Task<bool> IsThereValidAllowanceForTheTrip(CreateBusinessTrip createBusinessTrip)
        {
            var isOnlyOne = true;
            var countryAllowances = await _countryService.GetAllCountryAllowancesByCountryName(createBusinessTrip.TripTo);

            var tripAllowances = countryAllowances.Where(x => (x.ValidFrom <= createBusinessTrip.DateFrom && x.ValidTo == null) ||
                                                              (x.ValidFrom <= createBusinessTrip.DateFrom && x.ValidTo >= createBusinessTrip.DateTo));

            if (tripAllowances.Count() == 1)
            {
                return true;
            }

            else
            {
                isOnlyOne = false;
            }

            return isOnlyOne;
        }

        public async Task<PreviewAssignmentViewModel> PrepareAssignmentGeneration(Guid businessTripId)
        {
            var businessTrip = await GetTripById(businessTripId);
            var destinationCountry = await _countryService.GetCountryByName(businessTrip.TripTo);
            var cyrrentCountryAllowance = destinationCountry.GetCurrentCountryAllowance();
            var employee = await _employeeService.GetEmployeeById(businessTrip.EmployeeId);
            var generateAssignment = new PreviewAssignmentViewModel
            {
                EmployeeFullName = $"{employee.FirstName} {employee.LastName}",
                DailyAllowance = cyrrentCountryAllowance.DailyAllowance,
                AccomodationAllowance = cyrrentCountryAllowance.AccomodationAllowance,
                TripTo = businessTrip.TripTo,
                FromDate = businessTrip.DateFrom,
                ToDate = businessTrip.DateTo,
                Position = employee.PositionName,
                OrganizationName = employee.Organization.OrganizationName,
                CurrencyCode = destinationCountry.CurrencyCode,
                TransportNumber = businessTrip.TripDetail.TransportNumber,
                TotalDays = businessTrip.TotalDays,
                Purpose = businessTrip.Purpose,
            };

            return generateAssignment;
        }
    }
}
