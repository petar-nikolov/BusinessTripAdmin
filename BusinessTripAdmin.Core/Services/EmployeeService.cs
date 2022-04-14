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
        private readonly IUserService _userService;

        public EmployeeService(IApplicationDbRepository applicationRepository, IUserService userService)
        {
            _applicationRepository = applicationRepository;
            _userService = userService;
        }

        public async Task<bool> ActivateEmployee(Guid employeeId)
        {
            var employeeToEdit = await GetEmployeeById(employeeId);
            var isActivated = await ChangeEmployeeStatus(employeeToEdit, true);
            return isActivated;
        }

        public async Task<bool> CreateEmployee(CreateEmployee createEmployee, string userId)
        {
            var userOrg = await _userService.GetOrganizationByUserId(userId);
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

        public async Task<bool> DeactivateEmployee(Guid employeeId)
        {
            var employeeToEdit = await GetEmployeeById(employeeId);
            var isDeactivated = await ChangeEmployeeStatus(employeeToEdit, false);
            return isDeactivated;
        }

        public async Task<bool> EditEmployee(CreateEmployee editEmployee, Guid employeeId)
        {
            var isEditted = true;

            var employeeToEdit = await _applicationRepository.GetAll<Employee>().FirstOrDefaultAsync(x => x.Id == employeeId);

            try
            {
                employeeToEdit.FirstName = editEmployee.FirstName;
                employeeToEdit.LastName = editEmployee.LastName;
                employeeToEdit.PositionName = editEmployee.PositionName;
                await _applicationRepository.SaveChangesAsync();
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

        public async Task<IEnumerable<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _applicationRepository.GetAll<Employee>().AsNoTracking().OrderByDescending(x => x.CreatedDate).Select(x => new EmployeeViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                PositionName = x.PositionName,
                EmployeeId = x.Id,
                IsActive = x.IsActive,
                OrganizationId = x.OrganizationId
            }).ToListAsync();

            return employees;
        }

        public async Task<IEnumerable<EmployeeViewModel>> GetAllEmployeesByOrganizationId(Guid organizationId)
        {
            var employees = await _applicationRepository.GetAll<Employee>().AsNoTracking().Where(x => x.OrganizationId == organizationId).OrderByDescending(x => x.CreatedDate).Select(x => new EmployeeViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                PositionName = x.PositionName,
                EmployeeId = x.Id,
                IsActive = x.IsActive,
                OrganizationId = x.OrganizationId
            }).ToListAsync();

            return employees;

        }

        public async Task<Employee> GetEmployeeById(Guid employeeId)
        {
            var employee = await _applicationRepository.GetAll<Employee>().FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employee == null)
            {
                return new Employee();
            }

            return employee;
        }

        private async Task<bool> ChangeEmployeeStatus(Employee employee, bool isActive)
        {
            var isChanged = true;
            try
            {
                employee.IsActive = isActive;
                await _applicationRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            when (ex is DbUpdateException ||
                  ex is DbUpdateConcurrencyException ||
                  ex is OperationCanceledException)

            {
                isChanged = false;
            }

            return isChanged;
        }
    }
}
