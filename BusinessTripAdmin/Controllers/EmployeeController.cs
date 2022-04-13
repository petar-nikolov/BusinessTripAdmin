using BusinessTripAdmin.Core.Abstract;
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
            var countries = await _employeeService.GetAllEmployees();
            return View(countries);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Create(CreateCountry createCountry)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(createCountry);
        //    }

        //    if (await _countryService.CreateCountry(createCountry))
        //    {
        //        ViewData[MessageConstants.SuccessMessage] = "Country has been created!";
        //    }
        //    else
        //    {
        //        ViewData[MessageConstants.ErrorMessage] = "Country creation failed!";
        //    }

        //    return Redirect("/Country/GetCountries");
        //}

    }
}
