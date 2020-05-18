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
    public class PostsController : Controller
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private readonly ILogger<HomeController> _logger;
        private readonly IBlogService _blogService;
        private readonly IUserService _userService;

        public PostsController(
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

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Posts()
        {
            var viewModel = await _blogService.GetAllAsync();
            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult LikeClicked(string postId)
        {
            _blogService.LikeClicked(User.Identity.Name, postId);
            return NoContent();
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreatePost(string postText)
        {
            _blogService.AddNewPostAsync(User.Identity.Name, postText);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Authorize]
        public IActionResult CreateComment(string commentText, string postId)
        {
            _blogService.AddNewCommentAsync(User.Identity.Name, commentText, postId);
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
