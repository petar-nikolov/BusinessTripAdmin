using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Extensions;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;

namespace BusinessTripAdmin.Controllers
{
    public class BusinessTripController : BaseController
    {
        private readonly IBusinessTripService _businessTripService;
        private readonly ICountryService _countryService;
        private readonly IEmployeeService _employeeService;
        private readonly IUserService _userService;
        private Dictionary<string, object> _data = new Dictionary<string, object>();

        private readonly IToastNotification _toastNotification;

        public BusinessTripController(
            IBusinessTripService businessTripService,
            ICountryService countryService,
            IEmployeeService employeeService,
            IUserService userService,
            IToastNotification toastNotification)
        {
            _businessTripService = businessTripService;
            _countryService = countryService;
            _employeeService = employeeService;
            _userService = userService;
            _toastNotification = toastNotification;
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
            ViewBag.Countries = data.Item1.Select(x => x.CountryName).ToList();
            ViewBag.Employees = data.Item2.ToList();
            var orgId = data.Item2.FirstOrDefault().OrganizationId;
            ViewBag.Organization = await _userService.GetOrganizationById(orgId);
            return View();
        }

        [HttpPost]
        [Route("BusinessTrip/CreateBusinessTrip/{userId}")]
        public async Task<IActionResult> CreateBusinessTrip(CreateBusinessTrip createBusinessTrip, string userId)
        {
            if (!ModelState.IsValid || !createBusinessTrip.Employees.Any())
            {
                _toastNotification.AddErrorToastMessage("Business Trip creation failed!");
                return View(createBusinessTrip);
            }

            if(!await _businessTripService.IsThereValidAllowanceForTheTrip(createBusinessTrip))
            {
                _toastNotification.AddErrorToastMessage("There is no allowances for the selected trip or there is more than one for the trip period.");
                return View(createBusinessTrip);
            }

            if (await _businessTripService.CreateBusinessTrip(createBusinessTrip))
            {
                _toastNotification.AddSuccessToastMessage("Business Trip has been created!");
            }
            else
            {
                _toastNotification.AddErrorToastMessage("Business Trip creation failed!");
            }

            return Redirect($"/BusinessTrip/GetBusinessTrips/{userId}");
        }
        
        [HttpGet]
        [Route("BusinessTrip/GenerateAssignment/{businessTripId}")]
        public async Task<IActionResult> GenerateAssignmentAsync(Guid businessTripId)
        {
            ViewBag.BusinessTripId = businessTripId;
            return View();
        }

        [HttpPost]
        [Route("BusinessTrip/PreviewAssignment/{businessTripId}")]
        public async Task<IActionResult> PreviewAssignmentAsync(PreviewAssignmentViewModel completedGeneratedAssignment, string businessTripId)
        {
            var generatedAssignment = await _businessTripService.PrepareAssignmentGeneration(Guid.Parse(businessTripId));
            generatedAssignment.TripByCyrillic = completedGeneratedAssignment.TripByCyrillic;
            generatedAssignment.TripToCyrillic = completedGeneratedAssignment.TripToCyrillic;
            generatedAssignment.EmployeeFullNameCyrillic = completedGeneratedAssignment.EmployeeFullNameCyrillic;
            generatedAssignment.PurposeCyrillic = completedGeneratedAssignment.PurposeCyrillic;
            ViewBag.GeneratedAssignment = generatedAssignment;
            return View();
        }

        public IActionResult PreviewAssignment()
        {
            return View();
        }
    }
}
