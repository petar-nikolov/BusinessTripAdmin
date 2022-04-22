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

        [Route("Country/EditCountry/{countryId}")]
        public async Task<IActionResult> EditCountry(Guid countryId)
        {
            var country = await _countryService.GetCountryById(countryId);
            var model = new EditCountry
            {
                Description = country.Description,
                CountryName = country.CountryName,
                CurrencyCode = country.CurrencyCode,
                LocalCurrency = country.LocalCurrency,
                TripCurrency = country.TripCurrency,
                CountryId = country.Id
            };

            ViewBag.OldCountryData = model;
            return View(model);
        }

        [HttpPost]
        [Route("Country/EditCountry/{countryId}")]
        public async Task<IActionResult> EditCountry([FromRoute] Guid countryId, EditCountry editCountry)
        {
            if (!ModelState.IsValid)
            {
                return View(editCountry);
            }

            if (await _countryService.EditCountry(countryId, editCountry))
            {
                ViewData[MessageConstants.SuccessMessage] = "Country has been editted!";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Country edit failed!";
            }
            return Redirect("/Country/GetCountries");
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
