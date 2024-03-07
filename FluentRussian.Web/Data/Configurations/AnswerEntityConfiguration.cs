using FluentRussian.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentRussian.Web.Data.Configurations
{
    public class AnswerEntityConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .HasOne(q => q.Question)
                .WithMany(a => a.Answers)
                .HasForeignKey(q => q.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.GenerateAnswers());
        }

        private ICollection<Answer> GenerateAnswers()
        {
            var answers = new HashSet<Answer>
            {
                new Answer()
                {
                    Id = 1,
                    QuestionId = 1,
                    AnswerText = "залетает",
                    IsCorrect = false
                },

                new Answer()
                {   
                    Id = 2,
                    QuestionId = 1,
                    AnswerText = "улетает",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 3,
                    QuestionId = 1,
                    AnswerText = "приходит",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 4,
                    QuestionId = 1,
                    AnswerText = "выходит",
                    IsCorrect = false
                },

                new Answer()
                {   
                    Id = 5,
                    QuestionId = 2,
                    AnswerText = "выучила",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 6,
                    QuestionId = 2,
                    AnswerText = "учила",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 7,
                    QuestionId = 2,
                    AnswerText = "изучала",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 8,
                    QuestionId = 2,
                    AnswerText = "научилась",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 9,
                    QuestionId = 3,
                    AnswerText = "получилось",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 10,
                    QuestionId = 3,
                    AnswerText = "получился",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 11,
                    QuestionId = 3,
                    AnswerText = "получил",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 12,
                    QuestionId = 3,
                    AnswerText = "получила",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 13,
                    QuestionId = 4,
                    AnswerText = "Саша",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 14,
                    QuestionId = 4,
                    AnswerText = "у Саши",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 15,
                    QuestionId = 4,
                    AnswerText = "с Сашей",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 16,
                    QuestionId = 4,
                    AnswerText = "Саше",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 17,
                    QuestionId = 5,
                    AnswerText = "Автобус",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 18,
                    QuestionId = 5,
                    AnswerText = "Автобуса",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 19,
                    QuestionId = 5,
                    AnswerText = "Автобусом",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 20,
                    QuestionId = 5,
                    AnswerText = "Автобусу",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 21,
                    QuestionId = 6,
                    AnswerText = "стоматолога",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 22,
                    QuestionId = 6,
                    AnswerText = "стоматологу",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 23,
                    QuestionId = 6,
                    AnswerText = "со стоматологом",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 24,
                    QuestionId = 6,
                    AnswerText = "к стоматологу",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 25,
                    QuestionId = 7,
                    AnswerText = "за которым",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 26,
                    QuestionId = 7,
                    AnswerText = "к которому",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 27,
                    QuestionId = 7,
                    AnswerText = "от которого",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 28,
                    QuestionId = 7,
                    AnswerText = "с которым",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 29,
                    QuestionId = 8,
                    AnswerText = "около",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 30,
                    QuestionId = 8,
                    AnswerText = "через",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 31,
                    QuestionId = 8,
                    AnswerText = "за час",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 32,
                    QuestionId = 8,
                    AnswerText = "рядом с",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 33,
                    QuestionId = 9,
                    AnswerText = "тюльпана",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 34,
                    QuestionId = 9,
                    AnswerText = "тюльпаны",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 35,
                    QuestionId = 9,
                    AnswerText = "тюльпанов",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 36,
                    QuestionId = 9,
                    AnswerText = "тюльпан",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 37,
                    QuestionId = 10,
                    AnswerText = "экзамены",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 38,
                    QuestionId = 10,
                    AnswerText = "экзаменов",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 39,
                    QuestionId = 10,
                    AnswerText = "экзаменами",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 40,
                    QuestionId = 10,
                    AnswerText = "об экзаменах",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 41,
                    QuestionId = 11,
                    AnswerText = "на четыре недели",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 42,
                    QuestionId = 11,
                    AnswerText = "четыре недели",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 43,
                    QuestionId = 11,
                    AnswerText = "до четырёх недель",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 44,
                    QuestionId = 11,
                    AnswerText = "за четыре недели",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 45,
                    QuestionId = 12,
                    AnswerText = "через",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 46,
                    QuestionId = 12,
                    AnswerText = "на",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 47,
                    QuestionId = 12,
                    AnswerText = "за",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 48,
                    QuestionId = 12,
                    AnswerText = "в",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 49,
                    QuestionId = 13,
                    AnswerText = "едем",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 50,
                    QuestionId = 13,
                    AnswerText = "приедем",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 51,
                    QuestionId = 13,
                    AnswerText = "ездим",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 52,
                    QuestionId = 13,
                    AnswerText = "доезжаем",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 53,
                    QuestionId = 14,
                    AnswerText = "ехать",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 54,
                    QuestionId = 14,
                    AnswerText = "приехать",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 55,
                    QuestionId = 14,
                    AnswerText = "заехать",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 56,
                    QuestionId = 14,
                    AnswerText = "доехать",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 57,
                    QuestionId = 15,
                    AnswerText = "начнётся",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 58,
                    QuestionId = 15,
                    AnswerText = "начался",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 59,
                    QuestionId = 15,
                    AnswerText = "начинается",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 60,
                    QuestionId = 15,
                    AnswerText = "начинался",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 61,
                    QuestionId = 16,
                    AnswerText = "слышу",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 62,
                    QuestionId = 16,
                    AnswerText = "слушаю",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 63,
                    QuestionId = 16,
                    AnswerText = "услышу",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 64,
                    QuestionId = 16,
                    AnswerText = "послушаю",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 65,
                    QuestionId = 17,
                    AnswerText = "можно",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 66,
                    QuestionId = 17,
                    AnswerText = "можешь",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 67,
                    QuestionId = 17,
                    AnswerText = "нужен",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 68,
                    QuestionId = 17,
                    AnswerText = "нужно",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 69,
                    QuestionId = 18,
                    AnswerText = "так как",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 70,
                    QuestionId = 18,
                    AnswerText = "потому что",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 71,
                    QuestionId = 18,
                    AnswerText = "поэтому",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 72,
                    QuestionId = 18,
                    AnswerText = "из-за этого",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 73,
                    QuestionId = 19,
                    AnswerText = "если бы",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 74,
                    QuestionId = 19,
                    AnswerText = "когда",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 75,
                    QuestionId = 19,
                    AnswerText = "из-за того",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 76,
                    QuestionId = 19,
                    AnswerText = "потому что",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 77,
                    QuestionId = 20,
                    AnswerText = "что",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 78,
                    QuestionId = 20,
                    AnswerText = "как",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 79,
                    QuestionId = 20,
                    AnswerText = "о чём",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 80,
                    QuestionId = 20,
                    AnswerText = "какой",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 81,
                    QuestionId = 21,
                    AnswerText = "masculine",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 82,
                    QuestionId = 21,
                    AnswerText = "feminine",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 83,
                    QuestionId = 22,
                    AnswerText = "masculine",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 84,
                    QuestionId = 22,
                    AnswerText = "feminine",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 85,
                    QuestionId = 23,
                    AnswerText = "как дела́",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 86,
                    QuestionId = 23,
                    AnswerText = "приве́т",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 87,
                    QuestionId = 23,
                    AnswerText = "хорошо",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 88,
                    QuestionId = 24,
                    AnswerText = "one",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 89,
                    QuestionId = 24,
                    AnswerText = "two",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 90,
                    QuestionId = 24,
                    AnswerText = "three",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 91,
                    QuestionId = 25,
                    AnswerText = "true",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 92,
                    QuestionId = 25,
                    AnswerText = "false",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 93,
                    QuestionId = 26,
                    AnswerText = "хорошо",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 94,
                    QuestionId = 26,
                    AnswerText = "спаси́бо",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 95,
                    QuestionId = 26,
                    AnswerText = "чень",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 96,
                    QuestionId = 27,
                    AnswerText = "хорошо",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 97,
                    QuestionId = 27,
                    AnswerText = "спаси́бо",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 98,
                    QuestionId = 27,
                    AnswerText = "о́чень",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 99,
                    QuestionId = 28,
                    AnswerText = "хорошо",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 100,
                    QuestionId = 28,
                    AnswerText = "спаси́бо",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 101,
                    QuestionId = 28,
                    AnswerText = "о́чень",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 102,
                    QuestionId = 29,
                    AnswerText = "я говори́т",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 103,
                    QuestionId = 29,
                    AnswerText = "ты говори́т",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 104,
                    QuestionId = 29,
                    AnswerText = "он говори́т",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 105,
                    QuestionId = 29,
                    AnswerText = "all are correct",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 106,
                    QuestionId = 30,
                    AnswerText = "он говори́т",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 107,
                    QuestionId = 30,
                    AnswerText = "она́ говор́ит",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 108,
                    QuestionId = 30,
                    AnswerText = "both are correct",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 109,
                    QuestionId = 31,
                    AnswerText = "only nouns",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 110,
                    QuestionId = 31,
                    AnswerText = "nouns, pronouns and adjectives",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 111,
                    QuestionId = 31,
                    AnswerText = "only pronouns",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 112,
                    QuestionId = 32,
                    AnswerText = "ты",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 113,
                    QuestionId = 32,
                    AnswerText = "мне",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 114,
                    QuestionId = 32,
                    AnswerText = "тебя́",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 115,
                    QuestionId = 33,
                    AnswerText = "I don't have time.",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 116,
                    QuestionId = 33,
                    AnswerText = "Do you have time?",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 117,
                    QuestionId = 33,
                    AnswerText = "Don't you have time?",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 118,
                    QuestionId = 34,
                    AnswerText = "никогда́",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 119,
                    QuestionId = 34,
                    AnswerText = "никто́",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 120,
                    QuestionId = 34,
                    AnswerText = "нигде́",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 121,
                    QuestionId = 35,
                    AnswerText = "э́то некраси́во",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 122,
                    QuestionId = 35,
                    AnswerText = "э́то нехорошо́",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 123,
                    QuestionId = 35,
                    AnswerText = "э́то не пра́вда",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 124,
                    QuestionId = 36,
                    AnswerText = "диких животных",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 125,
                    QuestionId = 36,
                    AnswerText = "диких животнях",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 126,
                    QuestionId = 37,
                    AnswerText = "о этом",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 127,
                    QuestionId = 37,
                    AnswerText = "об этом",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 128,
                    QuestionId = 37,
                    AnswerText = "о эте",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 129,
                    QuestionId = 38,
                    AnswerText = "первый",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 130,
                    QuestionId = 38,
                    AnswerText = "второй",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 131,
                    QuestionId = 38,
                    AnswerText = "третий",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 132,
                    QuestionId = 39,
                    AnswerText = "на этом году",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 133,
                    QuestionId = 39,
                    AnswerText = "в этом году",
                    IsCorrect = true
                },

                new Answer()
                {
                    Id = 134,
                    QuestionId = 39,
                    AnswerText = "в этом годе",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 135,
                    QuestionId = 40,
                    AnswerText = "маленьких ребёнках",
                    IsCorrect = false
                },

                new Answer()
                {
                    Id = 136,
                    QuestionId = 40,
                    AnswerText = "маленьких детях",
                    IsCorrect = true
                },
            };

            return answers.ToArray();
        }
    }
}
