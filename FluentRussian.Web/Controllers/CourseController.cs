using FluentRussian.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace FluentRussian.Web.Controllers
{
    public class CourseController : BaseController
    {
        private readonly IApplicationService _applicationService;

        public CourseController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<IActionResult> Index()
        {
            var currentUserId = this.GetUserId();

            var languageLevel = await this._applicationService.GetUserLanguageLevelAsync(currentUserId);

            if (languageLevel == Models.LanguageLevel.None)
            {
                return this.RedirectToAction("Index", "Test");
            }

            ViewBag.LanguageLevel = languageLevel.ToString();

            return View();
        }
    }
}
