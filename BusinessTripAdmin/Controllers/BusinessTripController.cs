using BusinessTripAdmin.Core.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Controllers
{
    public class BusinessTripController : BaseController
    {
        private readonly IBusinessTripService _businessTripService;
        private readonly ICountryService _countryService;
        private readonly IEmployeeService _employeeService;

        public BusinessTripController(IBusinessTripService businessTripService, ICountryService countryService, IEmployeeService employeeService)
        {
            _businessTripService = businessTripService;
            _countryService = countryService;
            _employeeService = employeeService;
        }

        [Route("BusinessTrip/GetBusinessTrips/{userId}")]
        public async Task<IActionResult> GetBusinessTrips([FromRoute] string userId)
        {
            var businessTrips = await _businessTripService.GelAllTrips(userId);
            return View(businessTrips);
        }

        [Route("BusinessTrip/CreateBusinessTrip/{userId}")]
        public async Task<IActionResult> CreateBusinessTrip(string userId)
        {
            var data = await _businessTripService.GetDataForCreateAsync(userId);
            ViewBag.Countries = data.Item1.Select(x => x.CountryName);
            ViewBag.Employees = data.Item2.Select(x => new { FullName = $"{x.FirstName} {x.MiddleName} {x.LastName}"});
            return View();
        }
    }
}
