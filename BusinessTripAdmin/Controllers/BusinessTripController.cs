using BusinessTripAdmin.Core.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Controllers
{
    public class BusinessTripController : BaseController
    {
        private readonly IBusinessTripService _businessTripService;
        private readonly ICountryService _countryService;

        public BusinessTripController(IBusinessTripService businessTripService, ICountryService countryService)
        {
            _businessTripService = businessTripService;
            _countryService = countryService;
        }

        [Route("BusinessTrip/GetBusinessTrips/{userId}")]
        public async Task<IActionResult> GetBusinessTrips([FromRoute] string userId)
        {
            var businessTrips = await _businessTripService.GelAllTrips(userId);
            var countries = await _countryService.GetAllCountries();
            ViewBag.Countries = countries;
            return View(businessTrips);
        }
    }
}
