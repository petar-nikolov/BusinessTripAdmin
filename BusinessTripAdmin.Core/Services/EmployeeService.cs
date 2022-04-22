using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Abstraction;
using BusinessTripAdmin.Infrastructure.Data.DbModels;
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
            var isActivated = true;
            try
            {
                var employeeToEdit = await GetEmployeeById(employeeId);
                await ChangeEmployeeStatus(employeeToEdit, true);
            }
            catch (Exception)
            {
                return false;
            }

            return isActivated;
        }

        public async Task<bool> CreateEmployee(CreateEmployee createEmployee, string userId)
        {
            var userOrg = await _userService.GetOrganizationIdByUserId(userId);
            var isCreated = true;

            var employee = new Employee
            {
                FirstName = createEmployee.FirstName,
                MiddleName = createEmployee.MiddleName,
                LastName = createEmployee.LastName,
                BirthDate = createEmployee.BirthDate,
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
            try
            {
                var employeeToEdit = await GetEmployeeById(employeeId);
                var isDeactivated = await ChangeEmployeeStatus(employeeToEdit, false);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public async Task<bool> EditEmployee(CreateEmployee editEmployee, Guid employeeId)
        {
            var isEditted = true;

            var employeeToEdit = await _applicationRepository.GetAll<Employee>().FirstOrDefaultAsync(x => x.Id == employeeId);

            if (employeeToEdit == null)
            {
                return false;
            }

            try
            {
                employeeToEdit.FirstName = editEmployee.FirstName;
                employeeToEdit.MiddleName = editEmployee.MiddleName;
                employeeToEdit.LastName = editEmployee.LastName;
                employeeToEdit.PositionName = editEmployee.PositionName;
                employeeToEdit.BirthDate = editEmployee.BirthDate;
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

        public async Task<IEnumerable<EmployeeViewModel>> GetActiveEmployeesByOrganizationId(Guid organizationId)
        {
            var employees = await _applicationRepository.GetAll<Employee>().AsNoTracking().Where(x => x.OrganizationId == organizationId &&
                                                                                                      x.IsActive)
                .OrderByDescending(x => x.CreatedDate)
                .Select(x => new EmployeeViewModel
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PositionName = x.PositionName,
                    EmployeeId = x.Id,
                    IsActive = x.IsActive,
                    OrganizationId = x.OrganizationId,
                    MiddleName = x.MiddleName,
                    BirthDate = x.BirthDate
                }).ToListAsync();

            return employees;
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
                OrganizationId = x.OrganizationId,
                MiddleName = x.MiddleName,
                BirthDate = x.BirthDate
            }).ToListAsync();

            return employees;
        }

        public async Task<Employee> GetEmployeeById(Guid employeeId)
        {
            var employee = await _applicationRepository.GetAll<Employee>().FirstOrDefaultAsync(x => x.Id == employeeId);
            if (employee == null)
            {
                throw new ArgumentException("No Employee");
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
