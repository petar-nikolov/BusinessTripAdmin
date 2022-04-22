using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.Constants;
using BusinessTripAdmin.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BusinessTripAdmin.Controllers
{
    public class CountryController : BaseController
    {
        private readonly IToastNotification _toastNotification;
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService, IToastNotification toastNotification)
        {
            _countryService = countryService;
            _toastNotification = toastNotification;
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
                _toastNotification.AddSuccessToastMessage("Country has been created!");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Country creation failed!");
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
                _toastNotification.AddSuccessToastMessage("Country has been editted!");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Country edit failed!");
            }
            return Redirect("/Country/GetCountries");
        }

        public async Task<IActionResult> CreateAllowance()
        {
            return View();
        }

        [HttpPost]
        [Route("Country/CreateAllowance/{countryName}")]
        public async Task<IActionResult> CreateAllowance(string countryName, CreateAllowance createAllowanceModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createAllowanceModel);
            }
            if (await _countryService.CreateAllowanceByCountryName(countryName, createAllowanceModel))
            {
                _toastNotification.AddSuccessToastMessage("Allowance has been created!");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Allowance creation failed!");
            }

            return Redirect($"/Country/ReviewAllowances/{countryName}");

        }

        [Route("Country/EditAllowance/{allowanceId}")]
        public async Task<IActionResult> EditAllowance(Guid allowanceId)
        {
            var allowanceToEdit = await _countryService.GetAllowanceById(allowanceId);
            var model = new CreateAllowance
            {
                AccomodationAllowance = allowanceToEdit.AccomodationAllowance,
                DailyAllowance = allowanceToEdit.DailyAllowance,
                ValidFrom = allowanceToEdit.ValidFrom,
                ValidTo = allowanceToEdit.ValidTo
            };
            return View(model);
        }

        [HttpPost]
        [Route("Country/EditAllowance/{allowanceId}")]
        public async Task<IActionResult> EditAllowance(Guid allowanceId, CreateAllowance editAllowance)
        {
            if (!ModelState.IsValid)
            {
                return View(editAllowance);
            }
            if (await _countryService.EditAllowance(allowanceId, editAllowance))
            {
                _toastNotification.AddSuccessToastMessage("Allowance has been editted!");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Allowance edit failed! Possible reasons: Incorrect values or matching allowances existing for the selected time period!");
            }

            return Redirect($"/Country/GetCountries");

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
