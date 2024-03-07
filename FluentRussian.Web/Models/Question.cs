using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentRussian.Web.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        public int TestId { get; set; }

        public string QuestionText { get; set; } = null!;

        [ForeignKey(nameof(TestId))]
        public virtual Test Test { get; set; } = null!;

        public virtual IEnumerable<Answer> Answers { get; set; } = new List<Answer>();
    }
}
