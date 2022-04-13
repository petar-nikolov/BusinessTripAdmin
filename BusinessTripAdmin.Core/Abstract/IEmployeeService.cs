using BusinessTripAdmin.Core.ViewModels;

namespace BusinessTripAdmin.Core.Abstract
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeViewModel>> GetAllEmployees();

        Task<bool> CreateEmployee(CreateEmployee createEmployee, string organizationId);
    }
}
