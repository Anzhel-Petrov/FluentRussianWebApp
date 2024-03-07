using FluentRussian.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentRussian.Web.Data.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasData(this.GenerateUsers());
        }

        private ICollection<ApplicationUser> GenerateUsers()
        {
            var users = new HashSet<ApplicationUser>
            {
                new ApplicationUser()
                {
                    Id = Guid.Parse("57662390-40E7-4F0F-BD24-08DC3DB7D571"),
                    LanguageLevel = LanguageLevel.A1,
                    UserName = "a1@test.bg",
                    NormalizedUserName = "A1@TEST.BG",
                    Email = "a1@test.bg",
                    NormalizedEmail = "A1@TEST.BG",
                    PasswordHash = "AQAAAAEAACcQAAAAEOvQGNhY201NMsXhgHAN+rAwdAu94Va0trMZ0rpr3ukW/vl9dz50jAUOPTI8gq0ROA==",
                    LockoutEnabled = true,
                    SecurityStamp = "QB6WIL4W4X2WZOFFL6YGNFEI3Q5I64KF"
                },

                new ApplicationUser()
                {
                    Id = Guid.Parse("33822001-5E21-49FB-BDED-08DC3DB33DC5"),
                    LanguageLevel = LanguageLevel.A2,
                    UserName = "a2@test.bg",
                    NormalizedUserName = "A2@TEST.BG",
                    Email = "a2@test.bg",
                    NormalizedEmail = "A2@TEST.BG",
                    PasswordHash = "AQAAAAEAACcQAAAAEMZ7tvlP/849uTDSn/0wkgPLLVYdZnDuLQmXwBCherHABV3xq2O7xFWg07vMC8yexw==",
                    LockoutEnabled = true,
                    SecurityStamp = "QJXYM6QEPMJTWNNPVUE5NSKKEFSCRUBV"
                },

                new ApplicationUser()
                {
                    Id = Guid.Parse("3F3986A6-3AC1-4677-F2B0-08DC3DCA209F"),
                    LanguageLevel = LanguageLevel.B1,
                    UserName = "b1@test.bg",
                    NormalizedUserName = "B1@TEST.BG",
                    Email = "b1@test.bg",
                    NormalizedEmail = "B1@TEST.BG",
                    PasswordHash = "AQAAAAEAACcQAAAAEDVJN2dN5Vq3tKxw6gXNwWzLU0y4CS+5BRaBRP77gDR2lzo+i6RWUfM7YhVEzdyEgg==",
                    LockoutEnabled = true,
                    SecurityStamp = "E3JW4QXMVNJW7P5HO2BTPA4X37ZL7XQM"
                },

                new ApplicationUser()
                {
                    Id = Guid.Parse("44F5ADDA-8F96-4627-5368-08DC3DBDAEA7"),
                    LanguageLevel = LanguageLevel.B2,
                    UserName = "b2@test.bg",
                    NormalizedUserName = "B2@TEST.BG",
                    Email = "b2@test.bg",
                    NormalizedEmail = "B2@TEST.BG",
                    PasswordHash = "AQAAAAEAACcQAAAAEJ3e8S8lzffJnTLs5iWvV+FjcS4XuZLEsKVjC4ovWlz0JmHG/DjKHpjbT2v8KuXcDQ==",
                    LockoutEnabled = true,
                    SecurityStamp = "NHK5PWVZQFDH4EUQMCCGFIW6YVLPQIFL"
                },
            };

            return users.ToArray();
        }
    }
}
