using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.Constants;
using BusinessTripAdmin.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();
            return View(employees);
        }

        public async Task<IActionResult> CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        [Route("Employee/CreateEmployee/{organizationId}")]
        public async Task<IActionResult> CreateEmployee(CreateEmployee createEmployee, string organizationId)
        {
            if (!ModelState.IsValid)
            {
                return View(createEmployee);
            }

            if (await _employeeService.CreateEmployee(createEmployee, organizationId))
            {
                ViewData[MessageConstants.SuccessMessage] = "Emplyoee has been created!";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Employee creation failed!";
            }

            return Redirect("/Employee/GetEmployees");
        }

    }
}
