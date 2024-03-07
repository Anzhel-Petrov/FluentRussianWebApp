using FluentRussian.Web.Data;
using FluentRussian.Web.Models;
using FluentRussian.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FluentRussian.Web.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IApplicationService _applicationService;

        public HomeController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (this.IsAuthenticated())
            {
                var currentUserId = this.GetUserId();

                var languageLevel = await this._applicationService.GetUserLanguageLevelAsync(currentUserId);

                switch (languageLevel)
                {
                    case LanguageLevel.A1:
                    case LanguageLevel.A2:
                    case LanguageLevel.B1:
                    case LanguageLevel.B2:
                        return this.RedirectToAction("Index", "Course");

                    case LanguageLevel.None:
                        return this.RedirectToAction("Index", "Test");    
                }
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
