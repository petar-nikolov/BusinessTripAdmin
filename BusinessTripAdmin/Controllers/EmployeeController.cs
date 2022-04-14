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

        [Route("Employee/EditEmployee/{employeeId}")]
        public async Task<IActionResult> EditEmployee(Guid employeeId)
        {
            var employeeToEdit = await _employeeService.GetEmployeeById(employeeId);
            var model = new CreateEmployee
            {
                FirstName = employeeToEdit.FirstName,
                LastName = employeeToEdit.LastName,
                PositionName = employeeToEdit.PositionName
            };
            return View(model);
        }

        [Route("Employee/Deactivate/{employeeId}")]
        public async Task<IActionResult> DeactivateEmployee(Guid employeeId)
        {
            var isDeactivated = await _employeeService.DeactivateEmployee(employeeId);

            if (isDeactivated)
            {
                ViewData[MessageConstants.SuccessMessage] = "Employee is deactivated successfully.";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Employee deactivation failed!";
            }

            return Redirect("/Employee/GetEmployees");
        }

        [Route("Employee/Activate/{employeeId}")]
        public async Task<IActionResult> ActivateEmployee(Guid employeeId)
        {
            var isActivated = await _employeeService.ActivateEmployee(employeeId);

            if (isActivated)
            {
                ViewData[MessageConstants.SuccessMessage] = "Employee is activated successfully.";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Employee activation failed!";
            }

            return Redirect("/Employee/GetEmployees");
        }

    }
}
