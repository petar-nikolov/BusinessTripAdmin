using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
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

        public async Task<ICollection<BusinessTripViewModel>> GelAllTrips(string userId)
        {
            var userOrgId = await _userService.GetOrganizationByUserId(userId);
            var organizationEmployees = await _employeeService.GetActiveEmployeesByOrganizationId(userOrgId);
            var employeeIds = organizationEmployees.Where(x => x.IsActive).Select(x => x.EmployeeId).ToList();
            var businessTrips = await _applicationDbRepository.GetAll<EmployeeBusinessTrip>().Where(x => employeeIds.Any(eid => eid == x.EmployeeId))
                .OrderByDescending(x => x.CreatedDate)
                .Select(bt => new BusinessTripViewModel
            {
                Employee = $"{bt.Employee.FirstName} {bt.Employee.LastName}",
                EmployeeId = bt.EmployeeId,
                DateFrom = bt.DateFrom,
                DateTo = bt.DateTo,
                TotalDays = bt.TotalDays,
                TripFrom = bt.TripFrom,
                TripTo = bt.TripTo
            }).ToListAsync();

            return businessTrips;
        }

        public async Task<(IEnumerable<CountryViewModel>, IEnumerable<EmployeeViewModel>)> GetDataForCreateAsync(string userId)
        {
            var userOrgId = await _userService.GetOrganizationByUserId(userId);
            var organizationEmployees = await _employeeService.GetActiveEmployeesByOrganizationId(userOrgId);
            var countries = await _countryService.GetAllCountries();
            return (countries, organizationEmployees);
        }
    }
}
