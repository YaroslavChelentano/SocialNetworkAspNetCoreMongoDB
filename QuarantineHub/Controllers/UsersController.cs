using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.Interfaces;

namespace MVC.Controllers
{
    public class UsersController : Controller
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly ILogger<UsersController> _logger;
        private readonly IBlogService _blogService;
        private readonly IUserService _userService;

        public UsersController(
            ILogger<UsersController> logger,
            IBlogService postService,
            IUserService userService
            )
        {
            _logger = logger;
            _blogService = postService;
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("Users", "Users");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Users()
        {
            var users = await _userService.GetAllAsync();
            return View(users);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Follow(string userEmail)
        {
            ViewData["authorizedUser"] = User.Identity.Name;
            _userService.Follow(User.Identity.Name, userEmail);
            return NoContent();
        }
        public IActionResult RemoveFriend(string userEmail)
        {
            ViewData["authorizedUser"] = User.Identity.Name;
            _userService.RemoveFriend(User.Identity.Name, userEmail);
            return NoContent();
        }
    }
}
