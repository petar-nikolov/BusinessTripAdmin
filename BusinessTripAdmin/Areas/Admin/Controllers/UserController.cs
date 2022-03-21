using BusinessTripAdmin.Core.Abstract;
using BusinessTripAdmin.Core.Constants;
using BusinessTripAdmin.Core.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Areas.Admin.Controllers
{
    public class UserController : BaseAreaController
    {
        private readonly RoleManager<IdentityRole> _rolemanager;
        private readonly IUserService _userService;

        public UserController(RoleManager<IdentityRole> rolemanager, IUserService userService)
        {
            _rolemanager = rolemanager;
            _userService = userService;
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
            if(!ModelState.IsValid)
            {
                return View(editModel);
            }

            if(await _userService.UpdateUser(editModel))
            {
                ViewData[MessageConstants.SuccessMessage] = "Update succeeded!";
            }
            else
            {
                ViewData[MessageConstants.ErrorMessage] = "Error occured while updating the user!";
            }

            return View(editModel);
        }

        [HttpPost]
        public async Task<IActionResult> SetRole()
        {
            return Ok();
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
