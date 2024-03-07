using FluentRussian.Web.Data;
using FluentRussian.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace FluentRussian.Web.Services
{
    public class ApplicationService : IApplicationService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApplicationService(
            ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<LanguageLevel?> GetUserLanguageLevelAsync(string userId)
        {
            var user = await _context.Users.FirstAsync(u => u.Id.ToString() == userId);

            return user.LanguageLevel;
        }

        public async Task<IEnumerable<Test>> GetTestByLanguageLevelAsync(string languageLevel)
        {
            return await _context.Tests.Where(x => x.Name == languageLevel).Include(q => q.Questions).ThenInclude(a => a.Answers).ToListAsync();
        }

        public async Task<int> GetAllCorrectAnswersAsync(IFormCollection iFormCollection)
        {
            int score = 0;
            string[] questionIds = iFormCollection["questionId"];

            var testId = int.Parse(iFormCollection["testId"]);

            var foo = await _context.Questions.Where(x => x.TestId == testId).Include(q => q.Answers).ToListAsync();

            foreach (var questionId in questionIds)
            {
                int correctAnswerId = foo.Find(q => q.Id == int.Parse(questionId)).Answers.Where(a => a.IsCorrect).FirstOrDefault().Id;

                string? answerGiven = iFormCollection[$"question_{questionId}"];

                if (answerGiven is not null)
                {
                    if (correctAnswerId == int.Parse(iFormCollection[$"question_{questionId}"]))
                    {
                        score++;
                    }
                }
            }

            return score;
        }

        public async Task<ApplicationUser> SetUserLanguageLevelByIdAsync(string userId, int score)
        {
            var currentUser = await _userManager.FindByIdAsync(userId);

            switch (score)
            {
                case <= 5:
                    currentUser.LanguageLevel = LanguageLevel.A1;
                    break;
                case >= 6 and <= 10:
                    currentUser.LanguageLevel = LanguageLevel.A2;
                    break;
                case >= 11 and <= 15:
                    currentUser.LanguageLevel = LanguageLevel.B1;
                    break;
                case >= 16:
                    currentUser.LanguageLevel = LanguageLevel.B2;
                    break;
            }

            await _userManager.UpdateAsync(currentUser);

            return currentUser;
        }
    }
}
