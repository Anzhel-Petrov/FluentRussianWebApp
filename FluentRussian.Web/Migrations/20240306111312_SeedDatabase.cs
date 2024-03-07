using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FluentRussian.Web.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageLevel = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LanguageLevel", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("33822001-5e21-49fb-bded-08dc3db33dc5"), 0, "8603cf59-2285-4a92-9f0d-2a0ee77004e9", "a2@test.bg", false, 2, true, null, "A2@TEST.BG", "A2@TEST.BG", "AQAAAAEAACcQAAAAEMZ7tvlP/849uTDSn/0wkgPLLVYdZnDuLQmXwBCherHABV3xq2O7xFWg07vMC8yexw==", null, false, "QJXYM6QEPMJTWNNPVUE5NSKKEFSCRUBV", false, "a2@test.bg" },
                    { new Guid("3f3986a6-3ac1-4677-f2b0-08dc3dca209f"), 0, "a0d75c37-1493-42ad-9161-e32b174452c9", "b1@test.bg", false, 3, true, null, "B1@TEST.BG", "B1@TEST.BG", "AQAAAAEAACcQAAAAEDVJN2dN5Vq3tKxw6gXNwWzLU0y4CS+5BRaBRP77gDR2lzo+i6RWUfM7YhVEzdyEgg==", null, false, "E3JW4QXMVNJW7P5HO2BTPA4X37ZL7XQM", false, "b1@test.bg" },
                    { new Guid("44f5adda-8f96-4627-5368-08dc3dbdaea7"), 0, "f4b53351-ceec-4fbe-a26c-f131a25fe64d", "b2@test.bg", false, 4, true, null, "B2@TEST.BG", "B2@TEST.BG", "AQAAAAEAACcQAAAAEJ3e8S8lzffJnTLs5iWvV+FjcS4XuZLEsKVjC4ovWlz0JmHG/DjKHpjbT2v8KuXcDQ==", null, false, "NHK5PWVZQFDH4EUQMCCGFIW6YVLPQIFL", false, "b2@test.bg" },
                    { new Guid("57662390-40e7-4f0f-bd24-08dc3db7d571"), 0, "df8b7716-5f40-4451-bc43-1f5ca30b8143", "a1@test.bg", false, 1, true, null, "A1@TEST.BG", "A1@TEST.BG", "AQAAAAEAACcQAAAAEOvQGNhY201NMsXhgHAN+rAwdAu94Va0trMZ0rpr3ukW/vl9dz50jAUOPTI8gq0ROA==", null, false, "QB6WIL4W4X2WZOFFL6YGNFEI3Q5I64KF", false, "a1@test.bg" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Entry Level" },
                    { 2, "A1" },
                    { 3, "A2" },
                    { 4, "B1" },
                    { 5, "B2" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuestionText", "TestId" },
                values: new object[,]
                {
                    { 1, "В пятницу Екатерина __________ в Берлин.", 1 },
                    { 2, "Моя дочь очень рано __________ читать.", 1 },
                    { 3, "Вчера у меня __________ вкусный торт..", 1 },
                    { 4, "Ты помнишь, что __________ сегодня экзамен?", 1 },
                    { 5, "__________ нет уже двадцать минут!", 1 },
                    { 6, "У меня болит зуб, завтра я пойду __________ .", 1 },
                    { 7, "У меня есть друг, __________ я встречаюсь один раз в год.", 1 },
                    { 8, "Мои занятия танцами начинаются __________ семи вечера.", 1 },
                    { 9, "На день рождения Ольге подарили 23 __________.", 1 },
                    { 10, "В деканате уже есть расписание __________ ?", 1 },
                    { 11, "Мы живём в Москве уже  __________ .", 1 },
                    { 12, "Я опаздываю, мой самолёт вылетает __________ 20 минут.", 1 },
                    { 13, "Каждые полгода мы  __________ на море.", 1 },
                    { 14, "На метро мы сможем  __________ до центра за 20 минут.", 1 },
                    { 15, "Спектакль __________ давно, вы уже опоздали.", 1 },
                    { 16, "Говорите громче, я вас плохо __________ .", 1 },
                    { 17, "Ты __________ пойти в парк, когда закончишь домашнюю работу. ", 1 },
                    { 18, "Сегодня хорошая погода,  __________ мы поедем кататься на велосипеде.", 1 },
                    { 19, "Я мог бы приготовить ужин, __________ успел.", 1 },
                    { 20, "Вы не знаете, __________ зовут нашего нового преподавателя?", 1 },
                    { 21, "The word ру́сский is of ... gender?", 2 },
                    { 22, "The word ру́сская is of ... gender.", 2 },
                    { 23, "How do you say \"hi\" in Russian?", 2 },
                    { 24, "How many genders are there in Russian?", 2 },
                    { 25, "In Russian the verb \"быть\" is always omitted.", 2 },
                    { 26, "How do you say \"thank you\" in Russian?", 3 },
                    { 27, "How do you say \"well\" in Russian?", 3 },
                    { 28, "How do you say \"very\" in Russian?", 3 },
                    { 29, "Choose the correct sentence.", 3 },
                    { 30, "Choose the correct sentence.", 3 },
                    { 31, "What can be declined in Russian?", 4 },
                    { 32, "Complete the sentence: У меня́ есть время́ для ...", 4 },
                    { 33, "What does \"У тебя́ есть вре́мя?\" mean?", 4 },
                    { 34, "How do you say \"never\" in Russian?", 4 },
                    { 35, "How do you say \"It's not true\" in Russian?", 4 },
                    { 36, "What is Prepositional plural for \"дикое животное\"?", 5 },
                    { 37, "Which options is correct? Я думаю ...", 5 },
                    { 38, "Which cardinal numeral does not have the ending \"ом\" in prepositional?", 5 },
                    { 39, "How do you say \"this year\" in Russian?", 5 },
                    { 40, "Finish the following sentence: Я читаю о ...", 5 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "залетает", false, 1 },
                    { 2, "улетает", true, 1 },
                    { 3, "приходит", false, 1 },
                    { 4, "выходит", false, 1 },
                    { 5, "выучила", false, 2 },
                    { 6, "учила", false, 2 },
                    { 7, "изучала", false, 2 },
                    { 8, "научилась", true, 2 },
                    { 9, "получилось", false, 3 },
                    { 10, "получился", true, 3 },
                    { 11, "получил", false, 3 },
                    { 12, "получила", false, 3 },
                    { 13, "Саша", false, 4 },
                    { 14, "у Саши", true, 4 },
                    { 15, "с Сашей", false, 4 },
                    { 16, "Саше", false, 4 },
                    { 17, "Автобус", false, 5 },
                    { 18, "Автобуса", true, 5 },
                    { 19, "Автобусом", false, 5 },
                    { 20, "Автобусу", false, 5 },
                    { 21, "стоматолога", false, 6 },
                    { 22, "стоматологу", false, 6 },
                    { 23, "со стоматологом", false, 6 },
                    { 24, "к стоматологу", true, 6 },
                    { 25, "за которым", false, 7 },
                    { 26, "к которому", false, 7 },
                    { 27, "от которого", false, 7 },
                    { 28, "с которым", true, 7 },
                    { 29, "около", true, 8 },
                    { 30, "через", false, 8 },
                    { 31, "за час", false, 8 },
                    { 32, "рядом с", false, 8 },
                    { 33, "тюльпана", true, 9 },
                    { 34, "тюльпаны", false, 9 },
                    { 35, "тюльпанов", false, 9 },
                    { 36, "тюльпан", false, 9 },
                    { 37, "экзамены", false, 10 },
                    { 38, "экзаменов", true, 10 },
                    { 39, "экзаменами", false, 10 },
                    { 40, "об экзаменах", false, 10 },
                    { 41, "на четыре недели", false, 11 },
                    { 42, "четыре недели", true, 11 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 43, "до четырёх недель", false, 11 },
                    { 44, "за четыре недели", false, 11 },
                    { 45, "через", true, 12 },
                    { 46, "на", false, 12 },
                    { 47, "за", false, 12 },
                    { 48, "в", false, 12 },
                    { 49, "едем", false, 13 },
                    { 50, "приедем", false, 13 },
                    { 51, "ездим", true, 13 },
                    { 52, "доезжаем", false, 13 },
                    { 53, "ехать", false, 14 },
                    { 54, "приехать", false, 14 },
                    { 55, "заехать", false, 14 },
                    { 56, "доехать", true, 14 },
                    { 57, "начнётся", false, 15 },
                    { 58, "начался", true, 15 },
                    { 59, "начинается", false, 15 },
                    { 60, "начинался", false, 15 },
                    { 61, "слышу", true, 16 },
                    { 62, "слушаю", false, 16 },
                    { 63, "услышу", false, 16 },
                    { 64, "послушаю", false, 16 },
                    { 65, "можно", false, 17 },
                    { 66, "можешь", true, 17 },
                    { 67, "нужен", false, 17 },
                    { 68, "нужно", false, 17 },
                    { 69, "так как", false, 18 },
                    { 70, "потому что", false, 18 },
                    { 71, "поэтому", true, 18 },
                    { 72, "из-за этого", false, 18 },
                    { 73, "если бы", true, 19 },
                    { 74, "когда", false, 19 },
                    { 75, "из-за того", false, 19 },
                    { 76, "потому что", false, 19 },
                    { 77, "что", false, 20 },
                    { 78, "как", true, 20 },
                    { 79, "о чём", false, 20 },
                    { 80, "какой", false, 20 },
                    { 81, "masculine", true, 21 },
                    { 82, "feminine", false, 21 },
                    { 83, "masculine", false, 22 },
                    { 84, "feminine", true, 22 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 85, "как дела́", false, 23 },
                    { 86, "приве́т", true, 23 },
                    { 87, "хорошо", false, 23 },
                    { 88, "one", false, 24 },
                    { 89, "two", false, 24 },
                    { 90, "three", true, 24 },
                    { 91, "true", false, 25 },
                    { 92, "false", true, 25 },
                    { 93, "хорошо", false, 26 },
                    { 94, "спаси́бо", true, 26 },
                    { 95, "чень", false, 26 },
                    { 96, "хорошо", true, 27 },
                    { 97, "спаси́бо", false, 27 },
                    { 98, "о́чень", false, 27 },
                    { 99, "хорошо", false, 28 },
                    { 100, "спаси́бо", false, 28 },
                    { 101, "о́чень", true, 28 },
                    { 102, "я говори́т", false, 29 },
                    { 103, "ты говори́т", false, 29 },
                    { 104, "он говори́т", true, 29 },
                    { 105, "all are correct", false, 29 },
                    { 106, "он говори́т", false, 30 },
                    { 107, "она́ говор́ит", false, 30 },
                    { 108, "both are correct", true, 30 },
                    { 109, "only nouns", false, 31 },
                    { 110, "nouns, pronouns and adjectives", true, 31 },
                    { 111, "only pronouns", false, 31 },
                    { 112, "ты", false, 32 },
                    { 113, "мне", false, 32 },
                    { 114, "тебя́", true, 32 },
                    { 115, "I don't have time.", false, 33 },
                    { 116, "Do you have time?", true, 33 },
                    { 117, "Don't you have time?", false, 33 },
                    { 118, "никогда́", true, 34 },
                    { 119, "никто́", false, 34 },
                    { 120, "нигде́", false, 34 },
                    { 121, "э́то некраси́во", false, 35 },
                    { 122, "э́то нехорошо́", false, 35 },
                    { 123, "э́то не пра́вда", true, 35 },
                    { 124, "диких животных", true, 36 },
                    { 125, "диких животнях", false, 36 },
                    { 126, "о этом", true, 37 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "AnswerText", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 127, "об этом", false, 37 },
                    { 128, "о эте", false, 37 },
                    { 129, "первый", false, 38 },
                    { 130, "второй", false, 38 },
                    { 131, "третий", true, 38 },
                    { 132, "на этом году", false, 39 },
                    { 133, "в этом году", true, 39 },
                    { 134, "в этом годе", false, 39 },
                    { 135, "маленьких ребёнках", false, 40 },
                    { 136, "маленьких детях", true, 40 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TestId",
                table: "Questions",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
