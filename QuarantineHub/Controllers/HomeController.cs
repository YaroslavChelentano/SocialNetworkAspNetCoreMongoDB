using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Quarantine.Entities;
using MVC.Interfaces;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly ILogger<HomeController> _logger;
        private readonly IBlogService _blogService;
        private readonly IUserService _userService;

        public HomeController(
            ILogger<HomeController> logger,
            IBlogService blogService,
            IUserService userService)
        {
            _logger = logger;
            _blogService = blogService;
            _userService = userService;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("Posts", "Posts");
        }

   
        [Authorize]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
