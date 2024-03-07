using FluentRussian.Web.Models;
using Humanizer.Localisation;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FluentRussian.Web.Data.Configurations
{
    public class QuestionEntityConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .HasOne(q => q.Test)
                .WithMany(q => q.Questions)
                .HasForeignKey(q => q.TestId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.GenerateQuestions());
        }

        private ICollection<Question> GenerateQuestions()
        {
            var questions = new HashSet<Question>
            {
                new Question()
                {
                    Id = 1,
                    TestId = 1,
                    QuestionText = "В пятницу Екатерина __________ в Берлин."
                },

                new Question()
                {
                    Id = 2,
                    TestId = 1,
                    QuestionText = "Моя дочь очень рано __________ читать."
                },

                new Question()
                {
                    Id = 3,
                    TestId = 1,
                    QuestionText = "Вчера у меня __________ вкусный торт.."
                },

                new Question()
                {
                    Id = 4,
                    TestId = 1,
                    QuestionText = "Ты помнишь, что __________ сегодня экзамен?"
                },

                new Question()
                {   
                    Id = 5,
                    TestId = 1,
                    QuestionText = "__________ нет уже двадцать минут!"
                },

                new Question()
                {
                    Id = 6,
                    TestId = 1,
                    QuestionText = "У меня болит зуб, завтра я пойду __________ ."
                },

                new Question()
                {
                    Id = 7,
                    TestId = 1,
                    QuestionText = "У меня есть друг, __________ я встречаюсь один раз в год."
                },

                new Question()
                {
                    Id = 8,
                    TestId = 1,
                    QuestionText = "Мои занятия танцами начинаются __________ семи вечера."
                },

                new Question()
                {
                    Id = 9,
                    TestId = 1,
                    QuestionText = "На день рождения Ольге подарили 23 __________."
                },

                new Question()
                {
                    Id = 10,
                    TestId = 1,
                    QuestionText = "В деканате уже есть расписание __________ ?"
                },

                new Question()
                {
                    Id = 11,
                    TestId = 1,
                    QuestionText = "Мы живём в Москве уже  __________ ."
                },

                new Question()
                {
                    Id = 12,
                    TestId = 1,
                    QuestionText = "Я опаздываю, мой самолёт вылетает __________ 20 минут."
                },

                new Question()
                {
                    Id = 13,
                    TestId = 1,
                    QuestionText = "Каждые полгода мы  __________ на море."
                },

                new Question()
                {
                    Id = 14,
                    TestId = 1,
                    QuestionText = "На метро мы сможем  __________ до центра за 20 минут."
                },

                new Question()
                {
                    Id = 15,
                    TestId = 1,
                    QuestionText = "Спектакль __________ давно, вы уже опоздали."
                },

                new Question()
                {
                    Id = 16,
                    TestId = 1,
                    QuestionText = "Говорите громче, я вас плохо __________ ."
                },

                new Question()
                {
                    Id = 17,
                    TestId = 1,
                    QuestionText = "Ты __________ пойти в парк, когда закончишь домашнюю работу. "
                },

                new Question()
                {
                    Id = 18,
                    TestId = 1,
                    QuestionText = "Сегодня хорошая погода,  __________ мы поедем кататься на велосипеде."
                },

                new Question()
                {
                    Id = 19,
                    TestId = 1,
                    QuestionText = "Я мог бы приготовить ужин, __________ успел."
                },

                new Question()
                {
                    Id = 20,
                    TestId = 1,
                    QuestionText = "Вы не знаете, __________ зовут нашего нового преподавателя?"
                },

                new Question()
                {
                    Id = 21,
                    TestId = 2,
                    QuestionText = "The word ру́сский is of ... gender?"
                },

                new Question()
                {
                    Id = 22,
                    TestId = 2,
                    QuestionText = "The word ру́сская is of ... gender."
                },

                new Question()
                {
                    Id = 23,
                    TestId = 2,
                    QuestionText = "How do you say \"hi\" in Russian?"
                },

                new Question()
                {
                    Id = 24,
                    TestId = 2,
                    QuestionText = "How many genders are there in Russian?"
                },

                new Question()
                {
                    Id = 25,
                    TestId = 2,
                    QuestionText = "In Russian the verb \"быть\" is always omitted."
                },

                new Question()
                {
                    Id = 26,
                    TestId = 3,
                    QuestionText = "How do you say \"thank you\" in Russian?"
                },

                new Question()
                {
                    Id = 27,
                    TestId = 3,
                    QuestionText = "How do you say \"well\" in Russian?"
                },

                new Question()
                {
                    Id = 28,
                    TestId = 3,
                    QuestionText = "How do you say \"very\" in Russian?"
                },

                new Question()
                {
                    Id = 29,
                    TestId = 3,
                    QuestionText = "Choose the correct sentence."
                },

                new Question()
                {
                    Id = 30,
                    TestId = 3,
                    QuestionText = "Choose the correct sentence."
                },

                new Question()
                {
                    Id = 31,
                    TestId = 4,
                    QuestionText = "What can be declined in Russian?"
                },

                new Question()
                {
                    Id = 32,
                    TestId = 4,
                    QuestionText = "Complete the sentence: У меня́ есть время́ для ..."
                },

                new Question()
                {
                    Id = 33,
                    TestId = 4,
                    QuestionText = "What does \"У тебя́ есть вре́мя?\" mean?"
                },

                new Question()
                {
                    Id = 34,
                    TestId = 4,
                    QuestionText = "How do you say \"never\" in Russian?"
                },

                new Question()
                {
                    Id = 35,
                    TestId = 4,
                    QuestionText = "How do you say \"It's not true\" in Russian?"
                },

                new Question()
                {
                    Id = 36,
                    TestId = 5,
                    QuestionText = "What is Prepositional plural for \"дикое животное\"?"
                },

                new Question()
                {
                    Id = 37,
                    TestId = 5,
                    QuestionText = "Which options is correct? Я думаю ..."
                },

                new Question()
                {
                    Id = 38,
                    TestId = 5,
                    QuestionText = "Which cardinal numeral does not have the ending \"ом\" in prepositional?"
                },

                new Question()
                {
                    Id = 39,
                    TestId = 5,
                    QuestionText = "How do you say \"this year\" in Russian?"
                },

                new Question()
                {
                    Id = 40,
                    TestId = 5,
                    QuestionText = "Finish the following sentence: Я читаю о ..."
                },
            };

            return questions.ToArray();
        }
    }
}
