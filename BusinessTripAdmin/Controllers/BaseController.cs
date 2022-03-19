using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
