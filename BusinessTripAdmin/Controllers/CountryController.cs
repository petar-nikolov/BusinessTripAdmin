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

        public IActionResult Create()
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

        [HttpPut]
        [Route("Country/EditCountry/{countryName}")]
        public async Task<IActionResult> EditCountry(string countryName, EditCountry editCountry)
        {
            return Ok();
        }

        [Route("Country/EditCountry/{countryName}")]
        public async Task<IActionResult> EditCountry(string countryName)
        {
            var country = await _countryService.GetCountryByName(countryName);
            var model = new EditCountry
            {
                OldDescription = country.Description,
                OldCountryName = countryName,
                OldCurrencyCode = country.CurrencyCode,
                OldLocalCurrency = country.LocalCurrency,
                OldTripCurrency = country.TripCurrency,
            };

            ViewBag.OldCountryData = model;
            return View();
        }

        public async Task<IActionResult> CreateAllowance()
        {
            return View();
        }

        [HttpPost]
        [Route("Country/CreateAllowance/{countryName}")]
        public async Task<IActionResult> CreateAllowance(string countryName, CreateAllowance allowanceViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(allowanceViewModel);
            }
            if (await _countryService.CreateAllowanceByCountryName(countryName, allowanceViewModel))
            {
                ViewData[MessageConstants.SuccessMessage] = "Allowance has been created!";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Allowance creation failed!";
            }

            return Redirect($"/Country/ReviewAllowances/{countryName}");

        }

        [Route("Country/ReviewAllowances/{countryName}")]
        public async Task<IActionResult> ReviewAllowances([FromRoute] string countryName)
        {
            var allowances = await _countryService.GetAllCountryAllowancesByCountryName(countryName);
            if (!allowances.Any())
            {
                return NotFound($"There are not existing allowances for {countryName} ");
            }
            return View(allowances);
        }
    }
}
