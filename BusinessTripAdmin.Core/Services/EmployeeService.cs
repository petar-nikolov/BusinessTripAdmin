using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Core.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IApplicationDbRepository _applicationRepository;

        public EmployeeService(IApplicationDbRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<bool> CreateEmployee(CreateEmployee createEmployee, string userId)
        {
            var userOrg = _applicationRepository.GetAll<ApplicationUser>().FirstOrDefault(x => x.Id == userId)?.OrganizationId;
            var isCreated = true;

            var employee = new Employee
            {
                FirstName = createEmployee.FirstName,
                LastName = createEmployee.LastName,
                PositionName = createEmployee.PositionName,
                OrganizationId = (Guid)userOrg,
                IsActive = true,
            };

            try
            {
                await _applicationRepository.AddAsync(employee);
                await _applicationRepository.SaveChangesAsync();
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

        public async Task<IEnumerable<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _applicationRepository.GetAll<Employee>().AsNoTracking().OrderByDescending(x => x.CreatedDate).Select(x => new EmployeeViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                PositionName = x.PositionName,
                EmployeeId = x.Id,
                OrganizationId = x.OrganizationId
            }).ToListAsync();

            return employees;
        }
    }
}
