using BusinessTripAdmin.Core.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Controllers
{
    public class BusinessTripController : BaseController
    {
        private readonly IBusinessTripService _businessTripService;

        public BusinessTripController(IBusinessTripService businessTripService)
        {
            _businessTripService = businessTripService;
        }

        [Route("BusinessTrip/GetBusinessTrips/{userId}")]
        public async Task<IActionResult> GetBusinessTrips([FromRoute]string userId)
        {
            var businessTrips = await _businessTripService.GelAllTrips(userId);
            return View(businessTrips);

        }
    }
}
