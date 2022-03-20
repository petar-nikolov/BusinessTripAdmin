using BusinessTripAdmin.Controllers;
using BusinessTripAdmin.Core.Abstract;
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
