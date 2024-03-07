using FluentRussian.Web.Data;
using FluentRussian.Web.Models;
using FluentRussian.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FluentRussian.Web.Controllers
{
    public class TestController : BaseController
    {
        private readonly IApplicationService _applicationService;
        private readonly UserManager<ApplicationUser> _userManager;

        public TestController(
            IApplicationService applicationService, 
            UserManager<ApplicationUser> userManager)
        {
            _applicationService = applicationService;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ViewBag.Tests = await _applicationService.GetTestByLanguageLevelAsync("Entry Level");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Submit(IFormCollection iFormCollection)
        {
            int score = await _applicationService.GetAllCorrectAnswersAsync(iFormCollection);

            var languageLevel = await this._applicationService.GetUserLanguageLevelAsync(this.GetUserId());

            if (languageLevel == LanguageLevel.None)
            {
                await _applicationService.SetUserLanguageLevelByIdAsync(this.GetUserId(), score);
            }

            ViewBag.QuestionsCount = iFormCollection["questionId"].Count;
            ViewBag.LanguageLevel = languageLevel;
            ViewBag.Score = score;

            return View("Result");
        }

        [HttpPost]
        public async Task<IActionResult> CourseTest(string languageLevel)
        {
            ViewBag.Tests = await _applicationService.GetTestByLanguageLevelAsync(languageLevel);

            return View("Index");
        }
    }
}
