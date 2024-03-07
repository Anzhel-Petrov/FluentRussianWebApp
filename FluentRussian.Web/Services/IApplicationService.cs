using FluentRussian.Web.Models;

namespace FluentRussian.Web.Services
{
    public interface IApplicationService
    {
        Task<LanguageLevel?> GetUserLanguageLevelAsync(string userId);
        Task<IEnumerable<Test>> GetTestByLanguageLevelAsync(string languageLevel);
        Task<int> GetAllCorrectAnswersAsync(IFormCollection iFormCollection);
        Task<ApplicationUser> SetUserLanguageLevelByIdAsync(string userId, int score);
    }
}
