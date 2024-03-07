using FluentRussian.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentRussian.Web.Data.Configurations
{
    public class TestEntityConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasData(this.GenerateTests());
        }

        private ICollection<Test> GenerateTests()
        {
            var tests = new HashSet<Test>
            {
                new Test()
                {
                    Id = 1,
                    Name = "Entry Level"
                },

                new Test()
                {
                    Id = 2,
                    Name = "A1"
                },

                new Test()
                {
                    Id = 3,
                    Name = "A2"
                },

                new Test()
                {
                    Id = 4,
                    Name = "B1"
                },

                new Test()
                {
                    Id = 5,
                    Name = "B2"
                },
            };

            return tests.ToArray();
        }
    }
}
