using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiladDarabzadeh.Data.Migrations
{
    /// <inheritdoc />
    public partial class Mig002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "audioQuestion",
                columns: table => new
                {
                    AudioQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    AudioFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldAnswerWithVoice = table.Column<bool>(type: "bit", nullable: false),
                    ShouldAnsweWithText = table.Column<bool>(type: "bit", nullable: false),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    doesItSelective = table.Column<bool>(type: "bit", nullable: false),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_audioQuestion", x => x.AudioQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CountOfQuestions = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<short>(type: "smallint", nullable: true),
                    QuestionCount = table.Column<short>(type: "smallint", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exam_CourseCycls_CycleId",
                        column: x => x.CycleId,
                        principalTable: "CourseCycls",
                        principalColumn: "CycleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "pictureQuestion",
                columns: table => new
                {
                    pictureQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    imageFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    ShouldAnswerWithVoice = table.Column<bool>(type: "bit", nullable: false),
                    ShouldAnsweWithText = table.Column<bool>(type: "bit", nullable: false),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    doesItSelective = table.Column<bool>(type: "bit", nullable: false),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pictureQuestion", x => x.pictureQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "textualQuestion",
                columns: table => new
                {
                    textualQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShouldAnswerWithVoice = table.Column<bool>(type: "bit", nullable: false),
                    ShouldAnsweWithText = table.Column<bool>(type: "bit", nullable: false),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    doesItSelective = table.Column<bool>(type: "bit", nullable: false),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_textualQuestion", x => x.textualQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "videoQuestion",
                columns: table => new
                {
                    videoQuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionGuide = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    QuestionText = table.Column<string>(type: "nvarchar(800)", maxLength: 400, nullable: false),
                    VideoFileName = table.Column<string>(type: "nvarchar(70)", nullable: false),
                    PlayingLimit = table.Column<byte>(type: "TINYINT", nullable: true),
                    ShouldAnswerWithVoice = table.Column<bool>(type: "bit", nullable: false),
                    ShouldAnsweWithText = table.Column<bool>(type: "bit", nullable: false),
                    ShouldCameraRecord = table.Column<bool>(type: "bit", nullable: false),
                    doesItSelective = table.Column<bool>(type: "bit", nullable: false),
                    doesItMultipleSelective = table.Column<bool>(type: "bit", nullable: false),
                    optionOneValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionOneText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionTwoValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionTwoText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionThreeValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionThreeText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFourValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFourText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionFiveValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionFiveText = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    optionSixValue = table.Column<byte>(type: "TINYINT", nullable: true),
                    optionSixText = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videoQuestion", x => x.videoQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "ExamCycleConnection",
                columns: table => new
                {
                    ECCId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamCycleConnection", x => x.ECCId);
                    table.ForeignKey(
                        name: "FK_ExamCycleConnection_CourseCycls_CycleId",
                        column: x => x.CycleId,
                        principalTable: "CourseCycls",
                        principalColumn: "CycleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExamCycleConnection_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserScoreExam",
                columns: table => new
                {
                    USEId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<byte>(type: "TINYINT", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScoreExam", x => x.USEId);
                    table.ForeignKey(
                        name: "FK_UserScoreExam_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserScoreExam_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "questionExamConnection",
                columns: table => new
                {
                    QuestionExamConnectionId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    AudioQuestionId = table.Column<int>(type: "int", nullable: true),
                    PictureQustionId = table.Column<int>(type: "int", nullable: true),
                    TextualQustionId = table.Column<int>(type: "int", nullable: true),
                    VideoQustionId = table.Column<int>(type: "int", nullable: true),
                    pictureQuestionId = table.Column<int>(type: "int", nullable: true),
                    textualQuestionId = table.Column<int>(type: "int", nullable: true),
                    videoQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionExamConnection", x => x.QuestionExamConnectionId);
                    table.ForeignKey(
                        name: "FK_questionExamConnection_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_questionExamConnection_audioQuestion_AudioQuestionId",
                        column: x => x.AudioQuestionId,
                        principalTable: "audioQuestion",
                        principalColumn: "AudioQuestionId");
                    table.ForeignKey(
                        name: "FK_questionExamConnection_pictureQuestion_pictureQuestionId",
                        column: x => x.pictureQuestionId,
                        principalTable: "pictureQuestion",
                        principalColumn: "pictureQuestionId");
                    table.ForeignKey(
                        name: "FK_questionExamConnection_textualQuestion_textualQuestionId",
                        column: x => x.textualQuestionId,
                        principalTable: "textualQuestion",
                        principalColumn: "textualQuestionId");
                    table.ForeignKey(
                        name: "FK_questionExamConnection_videoQuestion_videoQuestionId",
                        column: x => x.videoQuestionId,
                        principalTable: "videoQuestion",
                        principalColumn: "videoQuestionId");
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 8, 1, 4, 38, 3, 896, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 8, 1, 4, 38, 3, 896, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.CreateIndex(
                name: "IX_Exam_CycleId",
                table: "Exam",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamCycleConnection_CycleId",
                table: "ExamCycleConnection",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ExamCycleConnection_ExamId",
                table: "ExamCycleConnection",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_questionExamConnection_AudioQuestionId",
                table: "questionExamConnection",
                column: "AudioQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_questionExamConnection_ExamId",
                table: "questionExamConnection",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_questionExamConnection_pictureQuestionId",
                table: "questionExamConnection",
                column: "pictureQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_questionExamConnection_textualQuestionId",
                table: "questionExamConnection",
                column: "textualQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_questionExamConnection_videoQuestionId",
                table: "questionExamConnection",
                column: "videoQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScoreExam_ExamId",
                table: "UserScoreExam",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScoreExam_UserId",
                table: "UserScoreExam",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExamCycleConnection");

            migrationBuilder.DropTable(
                name: "questionExamConnection");

            migrationBuilder.DropTable(
                name: "UserScoreExam");

            migrationBuilder.DropTable(
                name: "audioQuestion");

            migrationBuilder.DropTable(
                name: "pictureQuestion");

            migrationBuilder.DropTable(
                name: "textualQuestion");

            migrationBuilder.DropTable(
                name: "videoQuestion");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 24, 3, 30, 36, 261, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "UserRegisterDate",
                value: new DateTime(2024, 7, 24, 3, 30, 36, 261, DateTimeKind.Local).AddTicks(997));
        }
    }
}
