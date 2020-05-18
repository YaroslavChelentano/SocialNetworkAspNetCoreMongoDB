using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quarantine.Entities;
using MVC.Interfaces;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly ILogger<AccountController> _logger;
        private readonly IBlogService _blogService;
        private readonly IUserService _userService;

        public AccountController(
            ILogger<AccountController> logger,
            IBlogService blogService,
            IUserService userService
            )
        {
            _logger = logger;
            _blogService = blogService;
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Profile()
        {
            var authorizedUser = new UserViewModel();
            var profileModel = new PortfolioViewModel();
            try
            {
                authorizedUser = await _userService.GetByEmailAsync(User.Identity.Name);
                profileModel = await _userService.GetProfileModel(authorizedUser);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            profileModel.IsAuthorized = true;

            return View(profileModel);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> UserDetailsByEmail(string authorEmail)
        {
            var authorizedUser = await _userService.GetByEmailAsync(User.Identity.Name);

            var userModel = await _userService.GetByEmailAsync(authorEmail);
            var profileModel = await _userService.GetProfileModel(userModel);

            if (authorizedUser.Email == profileModel.Email)
            {
                profileModel.IsAuthorized = true;
            }
            return View("Profile", profileModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateUserDetails(PortfolioViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var userProfile = await _userService.UpdateUserAsync(viewModel);
                return RedirectToAction("Profile", "Account");
            }
            ModelState.AddModelError("", "Auth failed");
            return NoContent();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool isAuthorized = await _userService
                    .CheckPasswordByEmailAsync(model.Email, model.Password);

                if (isAuthorized)
                {
                    await Authenticate(model.Email);

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Auth failed");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(SignUpViewModel model)
        {
            if (ModelState.IsValid)
            {
                bool isUserExists = await _userService.IsUserExistsAsync(model.Email);
                if (!isUserExists)
                {
                    if (model.Password == model.ConfirmPassword)
                    {
                        var newUser = new UserViewModel()
                        {
                            Email = model.Email,
                            Password = model.Password,
                            Name = "Isolated",
                            Nickname = "Guy",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcR5bwNVHJYXhAZQFLQ5GPvqNw5nYvpzTkO_VYH1gHZnxGTWRg8Q&usqp=CAU",
                            Subscribers = new List<Subscriber>()
                        };
                        _userService.InsertUserAsync(newUser);
                    }
                    return RedirectToAction("Profile", "Account");
                }
                else
                    ModelState.AddModelError("", "Auth failed");
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

        private async Task Authenticate(string userName)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}