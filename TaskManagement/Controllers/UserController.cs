using ApplicationCore.Interfaces.Services;
using ApplicationCore.Models.Users;
using Microsoft.AspNetCore.Mvc;

namespace TaskManagement.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var users = await _userService.GetUsersAsync();
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserPost userRegistration)
        {
            if (ModelState.IsValid)
            {
                var createdUser = await _userService.CreateUser(userRegistration);
                return RedirectToAction(nameof(Details), new { userId = createdUser.Id });
            }

            return View(userRegistration);
        }

        public async Task<IActionResult> Details(int userId)
        {
            var user = await _userService.GetUserByIdAsync(userId);
            if (user == null)
                return NotFound();

            return View(user);
        }
    }
}
