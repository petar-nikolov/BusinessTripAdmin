using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Core.Services
{
    public class BusinessTripService : IBusinessTripService
    {
        private readonly IUserService _userService;
        private readonly IEmployeeService _employeeService;
        private readonly IApplicationDbRepository _applicationDbRepository;

        public BusinessTripService(IUserService userService, IEmployeeService employeeService, IApplicationDbRepository applicationDbRepository)
        {
            _userService = userService;
            _employeeService = employeeService;
            _applicationDbRepository = applicationDbRepository;
        }

        public async Task<ICollection<BusinessTripViewModel>> GelAllTrips(string userId)
        {
            var userOrgId = await _userService.GetOrganizationByUserId(userId);
            var organizationEmployees = await _employeeService.GetAllEmployeesByOrganizationId(userOrg);
            var employeeIds = organizationEmployees.Where(x => x.IsActive).Select(x => x.EmployeeId).ToList();
            var currentOrganizationLocalCountry = _applicationDbRepository.
            var businessTrips = await _applicationDbRepository.GetAll<EmployeeBusinessTrip>().Where(x => employeeIds.Any(eid => eid == x.EmployeeId)).Select(bt => new BusinessTripViewModel
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
    }
}
