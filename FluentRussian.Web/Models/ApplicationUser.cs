using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace FluentRussian.Web.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public LanguageLevel LanguageLevel { get; set; } = LanguageLevel.None;
    }
}
