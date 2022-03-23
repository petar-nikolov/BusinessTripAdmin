using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.Constants;
using BusinessTripAdmin.Core.ViewModels;
using BusinessTripAdmin.Infrastructure.Data.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BusinessTripAdmin.Areas.Admin.Controllers
{
    public class UserController : BaseAreaController
    {
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IUserService _userService;

        public UserController(RoleManager<IdentityRole> rolemanager, IUserService userService, UserManager<ApplicationUser> userManager)
        {
            _rolemanager = rolemanager;
            _userService = userService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageUsers()
        {
            var currentUsers = await _userService.GetUsers();
            return View(currentUsers);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var userToEdit = await _userService.GetUserForEdit(id);
            return View(userToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserEdit editModel)
        {
            if (!ModelState.IsValid)
            {
                return View(editModel);
            }

            if (await _userService.UpdateUser(editModel))
            {
                ViewData[MessageConstants.SuccessMessage] = "Update succeeded!";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Error occured while updating the user!";
            }

            return View(editModel);
        }

        public async Task<IActionResult> Roles(string id)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == id);

            var model = new UserRolesList
            {
                UserId = user.Id,
                Name = $"{user.FirstName} {user.LastName}"
            };

            var roles = _rolemanager.Roles.ToList();
            var roleItems = roles
                .Select(x => new SelectListItem
                {
                    Text = x.Name,
                    Value = x.Id,
                    Selected = _userManager.IsInRoleAsync(user, x.Name).Result
                }).ToList();

            ViewBag.RoleItems = roleItems;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Roles(UserRolesList model)
        {
            return Ok(model);
        }

        public async Task<IActionResult> CreateRole()
        {
            //await _rolemanager.CreateAsync(new IdentityRole
            //{
            //    Name = "Administrator"
            //});

            return Ok();
        }
    }
}
