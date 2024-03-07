using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FluentRussian.Web.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public string AnswerText { get; set; } = null!;

        public bool IsCorrect { get; set; }

        [ForeignKey(nameof(QuestionId))]
        public virtual Question Question { get; set; } = null!;

    }
}
