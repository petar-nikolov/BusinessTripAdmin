using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.DbModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeViewModel>> GetAllEmployees();

        Task<IEnumerable<EmployeeViewModel>> GetActiveEmployeesByOrganizationId(Guid organizationId);

        Task<bool> CreateEmployee(CreateEmployee createEmployee, string organizationId);

        Task<bool> EditEmployee(CreateEmployee createEmployee, Guid employeeId);

        Task<bool> DeactivateEmployee(Guid employeeId);

        Task<bool> ActivateEmployee(Guid employeeId);

        Task<Employee> GetEmployeeById(Guid employeeId);
    }
}
