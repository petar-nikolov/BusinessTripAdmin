using BusinessTripAdmin.Core.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Controllers
{
    public class CountryController : BaseController
    {

        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        //public IActionResult GetCountries()
        //{
        //    var countries = _countryService.GetAllCountries();
        //}
    }
}
