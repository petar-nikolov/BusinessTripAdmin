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

        public EmployeeService(IApplicationDbRepository applicationRepository)
        {
            _applicationRepository = applicationRepository;
        }

        public async Task<IEnumerable<EmployeeViewModel>> GetAllEmployees()
        {
            var employees = await _applicationRepository.GetAll<Employee>().AsNoTracking().OrderByDescending(x => x.CreatedDate).Select(x => new EmployeeViewModel
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                PositionName = x.PositionName,
                EmployeeId = x.Id
            }).ToListAsync();

            return employees;
        }
    }
}
