using BusinessTripAdmin.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Areas.Admin.Controllers
{
    [Authorize(Roles = UserConstants.AdministratorRole)]
    [Area("Admin")]
    public class BaseAreaController : Controller
    {
    }
}
