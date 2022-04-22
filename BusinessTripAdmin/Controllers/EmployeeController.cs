using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BusinessTripAdmin.Controllers
{
    public class EmployeeController : BaseController
    {
        private readonly IEmployeeService _employeeService;
        private readonly IToastNotification _toastNotification;

        public EmployeeController(IEmployeeService employeeService, IToastNotification toastNotification)
        {
            _employeeService = employeeService;
            _toastNotification = toastNotification;
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
                _toastNotification.AddSuccessToastMessage("Emplyoee has been created!");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Employee creation failed!");
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
                PositionName = employeeToEdit.PositionName,
                MiddleName = employeeToEdit.MiddleName,
                BirthDate = employeeToEdit.BirthDate
            };

            return View(model);
        }

        [HttpPost]
        [Route("Employee/EditEmployee/{employeeId}")]
        public async Task<IActionResult> EditEmployee(CreateEmployee employeeToEdit, Guid employeeId)
        {
            if (!ModelState.IsValid)
            {
                return View(employeeToEdit);
            }

            if (await _employeeService.EditEmployee(employeeToEdit, employeeId))
            {
                _toastNotification.AddSuccessToastMessage("Emplyoee has been editted!");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Employee edit failed!");
            }

            return Redirect("/Employee/GetEmployees");
        }

        [Route("Employee/Deactivate/{employeeId}")]
        public async Task<IActionResult> DeactivateEmployee(Guid employeeId)
        {
            var isDeactivated = await _employeeService.DeactivateEmployee(employeeId);

            if (isDeactivated)
            {
                _toastNotification.AddSuccessToastMessage("Employee is deactivated successfully");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Employee deactivation failed!");
            }

            return Redirect("/Employee/GetEmployees");
        }

        [Route("Employee/Activate/{employeeId}")]
        public async Task<IActionResult> ActivateEmployee(Guid employeeId)
        {
            var isActivated = await _employeeService.ActivateEmployee(employeeId);

            if (isActivated)
            {
                _toastNotification.AddSuccessToastMessage("Employee is activated successfully");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Employee activation failed!");
            }

            return Redirect("/Employee/GetEmployees");
        }

    }
}
