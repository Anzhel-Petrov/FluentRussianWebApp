using System.ComponentModel.DataAnnotations;

namespace FluentRussian.Web.Models
{
    public class Test
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public virtual IEnumerable<Question> Questions { get; set; } = new List<Question>();
    }
}
