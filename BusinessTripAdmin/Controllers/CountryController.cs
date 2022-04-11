using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.Constants;
using BusinessTripAdmin.Core.ViewModels;
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

        public async Task<IActionResult> GetCountries()
        {
            var countries = await _countryService.GetAllCountries();
            return View(countries);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCountry createCountry)
        {
            if (!ModelState.IsValid)
            {
                return View(createCountry);
            }

            if (await _countryService.CreateCountry(createCountry))
            {
                ViewData[MessageConstants.SuccessMessage] = "Country has been created!";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Country creation failed!";
            }

            return Redirect("/Country/GetCountries");
        }
    }
}
